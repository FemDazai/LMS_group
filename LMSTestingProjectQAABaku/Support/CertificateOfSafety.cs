using LMSTestingProjectQAABaku.Drivers;

namespace LMSTestingProjectQAABaku.Support
{
    public  class CertificateOfSafety
    {
        public void GetCertificateOfSafety()
        {
            DriverStorage storage = DriverStorage.Get();
            string xpacth = @"/html/body/div/div[2]/button[3]";
            IWebElement button = storage.Driver.FindElement(By.XPath(xpacth));
            button.Click();
            xpacth = @"/html/body/div/div[3]/p[2]/a";
            button = storage.Driver.FindElement(By.XPath(xpacth));
            button.Click();
        }
    }
}
