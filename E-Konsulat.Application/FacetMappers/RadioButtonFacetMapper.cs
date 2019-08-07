using E_Konsulat.Application.FacetMappers.Base;
using E_Konsulat.Domain.Models.Form;
using OpenQA.Selenium.Chrome;

namespace E_Konsulat.Application.FacetMappers
{
    internal class RadioButtonFacetMapper : BaseFacetMapper
    {
        public RadioButtonFacetMapper(ChromeDriver driver) : base(driver)
        {
        }

        public override void SetFacetValue(Facet facet, object facetValue)
        {
            var radioButton = GetHtmlElementById(facet.Selector);

            if (facetValue is bool isSelected && isSelected)
            {
                radioButton.Click();
            }
        }
    }
}
