using LMSTestingProjectQAABaku.Drivers;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSTestingProjectQAABaku.Pages
{
    public class AuthPage : AbstractPage
    {
        public IWebElement TextBoxEmailForAuth => _driver.FindElement(By.XPath(@"//input[@class='form-input']"));

        public IWebElement TextBoxPasswordForAuth => _driver.FindElement(By.XPath(@"//input[@class='form-input custom-password']"));

        public IWebElement TextBoxUserName => _driver.FindElement(By.XPath(@"//span[@class='avatar-name transition-styles'])"));

        public IWebElement ButtonForAuth => _driver.FindElement(By.XPath(@"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']"));

        public override void Open()
        {
            _driver.Navigate().GoToUrl("https://piter-education.ru:7074/login");
        }

        public void EnterTextForAuthUser(string text)
        {
            TextBoxEmailForAuth.SendKeys(text);
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

    }
}
