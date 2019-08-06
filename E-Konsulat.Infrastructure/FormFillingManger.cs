using OpenQA.Selenium.Chrome;

namespace E_Konsulat.Infrastructure
{
    public class FormFillingManger
    {
        // chrome -remote-debugging-port=9014 --user-data-dir="D:\Projects\E-Konsulat\UserData"
        public void WriteFieldValues()
        {
            var chromeOptions = new ChromeOptions
            {
                DebuggerAddress = "localhost:9014"
            };

            var driver = new ChromeDriver("D:\\Projects\\E-Konsulat\\Libs", chromeOptions);
            var elem = driver.FindElementById("cp_f_daneOs_txtNazwisko");

            elem.SendKeys("hello world");
        }
    }
}
