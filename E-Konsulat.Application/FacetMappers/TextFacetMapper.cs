using E_Konsulat.Application.FacetMappers.Base;
using E_Konsulat.Domain.Models.Form;
using OpenQA.Selenium.Chrome;

namespace E_Konsulat.Application.FacetMappers
{
    internal class TextFacetMapper : BaseFacetMapper
    {
        public TextFacetMapper(ChromeDriver driver) : base(driver)
        {
        }

        public override void SetFacetValue(Facet facet, object facetValue)
        {
            var input = GetHtmlElementById(facet.Selector);
            var inputValue = facetValue?.ToString() ?? string.Empty;

            input.SendKeys(inputValue);
        }
    }
}
