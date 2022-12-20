
namespace LMSTestingProjectQAABaku.Pages
{
    public class AuthPage : AbstractPage
    {
        public IWebElement TextBoxEmailForAuth => _driver.FindElement(By.XPath(@"//input[@class='form-input']"));
        public IWebElement TextBoxPasswordForAuth => _driver.FindElement(By.XPath(@"//input[@class='form-input custom-password']"));
        public IWebElement TextBoxUserName => _driver.FindElement(By.XPath(@"//span[@class='avatar-name transition-styles']"));
        public IWebElement ButtonForAuth => _driver.FindElement(By.XPath(@"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']"));
        public IWebElement PictureButton => _driver.FindElement(By.XPath(@"/html/body/div/div/aside/div/div[1]/div[2]"));

        public override void Open()
        {
            _driver.Navigate().GoToUrl("https://piter-education.ru:7074/login");
        }

        public void EnterEmail(string text)
        {
            TextBoxEmailForAuth.SendKeys(text);
        }

        public void EnterPassword(string text)
        {
            TextBoxPasswordForAuth.Clear();
            TextBoxPasswordForAuth.SendKeys(text);
        }

        public void ClickAuthButton()
        {
            ButtonForAuth.Click();
            Thread.Sleep(1000);
        }

        public string GetButtonByName()
        {
            return TextBoxUserName.Text;
        }
        public void ClickOnPicture()
        {
            PictureButton.Click();
        }
    }
}
