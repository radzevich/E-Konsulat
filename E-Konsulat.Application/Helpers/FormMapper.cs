using System;
using System.Threading.Tasks;
using E_Konsulat.Domain;
using E_Konsulat.Domain.Models.Form;
using E_Konsulat.Domain.Providers;
using OpenQA.Selenium.Chrome;

namespace E_Konsulat.Application.Helpers
{
    public class FormMapper
    {
        private readonly IFormSchemaProvider _schemaProvider;
        private readonly IFormDataProvider _dataProvider;

        public FormMapper(
            IFormSchemaProvider schemaProvider,
            IFormDataProvider dataProvider)
        {
            _schemaProvider = schemaProvider;
            _dataProvider = dataProvider;
        }

        public async Task Map()
        {
            var driver = GetDriver();

            var schema = await _schemaProvider.LoadSchemaAsync("sdf");
            var data = await _dataProvider.LoadFormDataAsync(schema.Id);

            WalkFormSchema(driver, schema, data);
        }

        private static ChromeDriver GetDriver()
        {
            var chromeOptions = new ChromeOptions
            {
                DebuggerAddress = "localhost:9014"
            };

            var driver = new ChromeDriver("D:\\Projects\\E-Konsulat\\Libs", chromeOptions);

            return driver;
        }

        private static void WalkFormSchema(ChromeDriver driver, FormNode node, FormData data)
        {
            if (node == null)
            {
                return;
            }

            switch (node.NodeType)
            {
                case NodeTypes.Text:
                    ProcessTextNode(driver, node, data);
                    break;
                case NodeTypes.Aggregation:
                    break;
                case NodeTypes.Select:
                    break;
                case NodeTypes.MultiSelect:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            if (node.ChildNodes == null)
            {
                return;
            }

            foreach (var childNode in node.ChildNodes)
            {
                WalkFormSchema(driver, childNode, data);
            }
        }

        private void ProcessAggregationNode(ChromeDriver driver, FormNode node, FormData data)
        {
            if (node.ChildNodes == null)
            {
                return;
            }

            foreach (var childNode in node.ChildNodes)
            {
                WalkFormSchema(driver, childNode, data);
            }
        }

        private static void ProcessTextNode(ChromeDriver driver, FormNode node, FormData data)
        {
            if (node is Facet facet)
            {
                var input = driver.FindElementById(facet.Selector);
                if (input == null)
                {
                    throw new Exception($"Element with id {facet.Selector} not found");
                }

                if (!data.Fields.TryGetValue(facet.DomainKey, out var inputValue))
                {
                    throw new Exception($"Data for input {facet.DomainKey} not found");
                }

                input.SendKeys(inputValue);
            }
        }
    }
}
