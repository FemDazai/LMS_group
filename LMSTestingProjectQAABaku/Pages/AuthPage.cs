
using OpenQA.Selenium.Support.UI;


namespace LMSTestingProjectQAABaku.Pages
{
    public class AuthPage : AbstractPage
    {
        public IWebElement TextBoxEmailForAuth => _driver.FindElement(By.XPath(@"//input[@placeholder='example@mail.ru']"));
        public IWebElement TextBoxPasswordForAuth => _driver.FindElement(By.XPath(@"//input[@class='form-input custom-password']"));
        public IWebElement TextBoxUserName
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//span[text()='Иван']")));
            }
        }
        public IWebElement ButtonForAuth => _driver.FindElement(By.XPath(@"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']"));
        public IWebElement PictureButton => _driver.FindElement(By.XPath(@"/html/body/div/div/aside/div/div[1]/div[2]"));
        public IWebElement NotificationWrongPasswordInput => _driver.FindElement(By.XPath(@"//div[text()=""Введите пароль""]"));
        public IWebElement NotificationWrongEmail => _driver.FindElement(By.XPath(@"//div[text()='Неправильные логин или пароль']"));


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
        }

        public string GetButtonByName()
        {
            return TextBoxUserName.Text;
        }

        public void ClickOnPicture()
        {
            PictureButton.Click();
        }

        public string GetNotificationWrongPassword()
        {
            return NotificationWrongPasswordInput.Text;
        }

        public string GetNotificationWrongEmail()
        {
            return NotificationWrongEmail.Text;
        }
    }
}
