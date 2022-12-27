using LMSTestingProjectQAABaku.Drivers;

namespace LMSTestingProjectQAABaku.Pages
{
    public abstract class AbstractPage
    {
        protected WebDriver _driver;

        public AbstractPage()
        { 
          _driver = DriverStorage.Get().Driver;
        }

        public void Refresh()
        { 
          _driver.Navigate().Refresh();
        }

        public abstract void Open();

        public void GetCertificateOfSafety()
        {
            DriverStorage storage = DriverStorage.Get();
            string xpath = @"/html/body/div/div[2]/button[3]";
            IWebElement button = storage.Driver.FindElement(By.XPath(xpath));
            button.Click();
            xpath = @"/html/body/div/div[3]/p[2]/a";
            button = storage.Driver.FindElement(By.XPath(xpath));
            button.Click();
        }
    }
}
