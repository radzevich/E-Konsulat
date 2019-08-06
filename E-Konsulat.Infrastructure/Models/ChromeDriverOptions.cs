using OpenQA.Selenium.Chrome;

namespace E_Konsulat.Infrastructure.Models
{
    public class ChromeDriverOptions : ChromeOptions
    {
        public string DriverPath { get; set; }
    }
}
