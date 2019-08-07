using E_Konsulat.Application.FacetMappers.Base;
using E_Konsulat.Domain.Models.Form;
using OpenQA.Selenium.Chrome;

namespace E_Konsulat.Application.FacetMappers
{
    internal class FallbackFacetMapper : BaseFacetMapper
    {
        public FallbackFacetMapper(ChromeDriver driver) : base(driver)
        {
        }

        public override void SetFacetValue(Facet facet, object facetValue)
        {
        }
    }
}
