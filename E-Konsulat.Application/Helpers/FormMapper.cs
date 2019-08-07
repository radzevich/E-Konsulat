using System.Threading.Tasks;
using E_Konsulat.Application.Factories;
using E_Konsulat.Application.Providers.Interfaces;
using E_Konsulat.Domain.Exceptions;
using E_Konsulat.Domain.Models.Form;
using E_Konsulat.Domain.Providers;
using OpenQA.Selenium.Chrome;

namespace E_Konsulat.Application.Helpers
{
    public class FormMapper
    {
        private readonly IChromeDriverProvider _driverProvider;
        private readonly IFormSchemaProvider _schemaProvider;
        private readonly IFormDataProvider _dataProvider;

        public FormMapper(
            IChromeDriverProvider driverProvider,
            IFormSchemaProvider schemaProvider,
            IFormDataProvider dataProvider)
        {
            _driverProvider = driverProvider;
            _schemaProvider = schemaProvider;
            _dataProvider = dataProvider;
        }

        public async Task Map()
        {
            var driver = _driverProvider.GetDriver();
            var schema = await _schemaProvider.LoadSchemaAsync("sdf");
            var data = await _dataProvider.LoadFormDataAsync(schema.Id);

            WalkFormSchema(driver, schema, data);
        }

        private static void WalkFormSchema(ChromeDriver driver, FormNode node, FormData data)
        {
            if (node == null)
            {
                return;
            }

            if (node is Facet facet)
            {
                var facetMapper = FacetMapperFactory.GetFacetMapper(driver, facet.FacetType);
                var inputValue = GetInputValue(data, facet.DomainKey);

                facetMapper.SetFacetValue(facet, inputValue);
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

        private static object GetInputValue(FormData data, string key)
        {
            if (!data.Fields.TryGetValue(key, out var inputValue))
            {
                throw new FormMappingException($"Data for input {key} not found");
            }

            return inputValue;
        }
    }
}
