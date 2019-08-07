using E_Konsulat.Domain.Exceptions;
using E_Konsulat.Domain.Models.Form;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace E_Konsulat.Application.FacetMappers.Base
{
    public abstract class BaseFacetMapper
    {
        private readonly ChromeDriver _driver;

        protected BaseFacetMapper(ChromeDriver driver)
        {
            _driver = driver;
        }

        public abstract void SetFacetValue(Facet facet, object facetValue);

        protected IWebElement GetHtmlElementById(string selector)
        {
            var htmlElement = _driver.FindElementById(selector);
            if (htmlElement == null)
            {
                throw new FormMappingException($"Element with id {selector} not found");
            }

            return htmlElement;
        }
    }
}
