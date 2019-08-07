using E_Konsulat.Application.FacetMappers.Base;
using E_Konsulat.Domain.Models.Form;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace E_Konsulat.Application.FacetMappers
{
    internal class DropdownFacetMapper : BaseFacetMapper
    {
        public DropdownFacetMapper(ChromeDriver driver) : base(driver)
        {
        }

        public override void SetFacetValue(Facet facet, object facetValue)
        {
            var dropdown = new SelectElement(GetHtmlElementById(facet.Selector));
            var inputValue = facetValue?.ToString() ?? string.Empty;

            dropdown.SelectByValue(inputValue);
        }
    }
}
