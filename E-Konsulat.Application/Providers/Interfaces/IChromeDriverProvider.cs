using OpenQA.Selenium.Chrome;

namespace E_Konsulat.Application.Providers.Interfaces
{
    public interface IChromeDriverProvider
    {
        ChromeDriver GetDriver();
    }
}
