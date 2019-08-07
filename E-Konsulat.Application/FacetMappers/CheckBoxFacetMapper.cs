using E_Konsulat.Application.FacetMappers.Base;
using E_Konsulat.Domain.Models.Form;
using OpenQA.Selenium.Chrome;

namespace E_Konsulat.Application.FacetMappers
{
    internal class CheckBoxFacetMapper : BaseFacetMapper
    {
        public CheckBoxFacetMapper(ChromeDriver driver) : base(driver)
        {
        }

        public override void SetFacetValue(Facet facet, object facetValue)
        {
            var checkBox = GetHtmlElementById(facet.Selector);

            if (facetValue is bool isSelected && isSelected)
            {
                checkBox.Click();
            }
        }
    }
}
