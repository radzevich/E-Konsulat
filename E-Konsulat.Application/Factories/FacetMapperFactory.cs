using System;
using E_Konsulat.Application.FacetMappers;
using E_Konsulat.Application.FacetMappers.Base;
using E_Konsulat.Domain;
using OpenQA.Selenium.Chrome;

namespace E_Konsulat.Application.Factories
{
    public static class FacetMapperFactory
    {
        public static BaseFacetMapper GetFacetMapper(ChromeDriver driver, FacetTypes facetType)
        {
            switch (facetType)
            {
                case FacetTypes.Text:
                    return new TextFacetMapper(driver);
                case FacetTypes.Dropdown:
                    return new DropdownFacetMapper(driver);
                case FacetTypes.CheckBox:
                    return new CheckBoxFacetMapper(driver);
                case FacetTypes.RadioButton:
                    return new RadioButtonFacetMapper(driver);
                case FacetTypes.Aggregation:
                    return new FallbackFacetMapper(driver);
                default:
                    throw new ArgumentOutOfRangeException(nameof(facetType), facetType, $"Facet type {facetType} is not supported");
            }
        }
    }
}
