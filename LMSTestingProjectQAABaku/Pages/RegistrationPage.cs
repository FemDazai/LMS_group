using OpenQA.Selenium.Support.UI; 
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;

namespace LMSTestingProjectQAABaku.Pages
{
    public class RegistrationPage: AbstractPage
    {
        public IWebElement TextBoxNotification
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//p[@class='notifications-container']")));
            }
        }
        public IWebElement TextBoxSurname => _driver.FindElement(By.XPath(@"//input[@placeholder='Ефременков']"));
        public IWebElement TextBoxName => _driver.FindElement(By.XPath(@"//input[@placeholder='Антон']"));
        public IWebElement TextBoxPatronymic => _driver.FindElement(By.XPath(@"//input[@placeholder='Сергеевич']"));
        public IWebElement TextBoxBirthDate => _driver.FindElement(By.XPath(@"//input[@class='form-control']"));
        public IWebElement TextBoxPassword => _driver.FindElement(By.XPath(@"//input[@name='password']"));
        public IWebElement TextBoxRepeatPassword => _driver.FindElement(By.XPath(@"//input[@name='confirmPassword']"));
        public IWebElement TextBoxEmail => _driver.FindElement(By.XPath(@"//input [@placeholder='example@example.com']"));
        public IWebElement TextBoxPhone => _driver.FindElement(By.XPath(@"//input [@placeholder='+7(999)888-77-66']"));
        public IWebElement ButtonRegistration => _driver.FindElement(By.XPath(@"//a[@class='auth-link']"));
        public IWebElement ButtonCheckBox => _driver.FindElement(By.XPath(@"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']"));
        public IWebElement TextNotification1 => _driver.FindElement(By.XPath(@"//p[@class='notification-text']"));
        public override void Open()
        {
            _driver.Navigate().GoToUrl("https://piter-education.ru:7074/login");
        }

        public void ClickRegistrationButton()
        {
            ButtonRegistration.Click();
        }

        public void ClickCheckBox()
        {
            ButtonCheckBox.Click();
        }

        public void EnterSurnameInField(string text)
        {
            TextBoxSurname.SendKeys(text);
        }

        public void EnterNameInField(string text)
        {
            TextBoxName.SendKeys(text);
        }

        public void EnterPatronymicInField(string text)
        {
            TextBoxPatronymic.SendKeys(text);
        }

        public void EnterBirthDateInField(string text)
        {
            Actions action = new Actions(_driver);
            action.DoubleClick(TextBoxBirthDate).Build().Perform();
            TextBoxBirthDate.SendKeys(Keys.Backspace);      
            TextBoxBirthDate.SendKeys(text);
        }

        public void EnterPasswordInField(string text)
        {
            TextBoxPassword.SendKeys(text);
        }

        public void EnterRepeatPasswordInField(string text)
        {
            TextBoxRepeatPassword.SendKeys(text);
        }

        public void EnterEmailInField(string text)
        {
            TextBoxEmail.SendKeys(text);
        }

        public void EnterPhoneInField(string text)
        {
            TextBoxPhone.SendKeys(text);
        }

        public string GetTextNotification()
        {
            return TextNotification1.Text;
        }
    }
}
