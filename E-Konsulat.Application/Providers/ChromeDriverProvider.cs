using E_Konsulat.Application.Providers.Interfaces;
using OpenQA.Selenium.Chrome;

namespace E_Konsulat.Application.Providers
{
    // chrome -remote-debugging-port=9014 --user-data-dir="D:\Projects\E-Konsulat\UserData"
    public class ChromeDriverProvider : IChromeDriverProvider
    {
        private const string DebuggerAddress = "localhost:9014";
        private const string ChromeDriverDirectory = "D:\\Projects\\E-Konsulat\\Libs";

        public ChromeDriver GetDriver()
        {
            var chromeOptions = new ChromeOptions
            {
                DebuggerAddress = DebuggerAddress
            };

            var driver = new ChromeDriver(ChromeDriverDirectory, chromeOptions);

            return driver;
        }
    }
}
