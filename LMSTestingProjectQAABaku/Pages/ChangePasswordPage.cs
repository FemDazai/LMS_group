using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LMSTestingProjectQAABaku.Pages
{
    public class ChangePasswordPage : AbstractPage
    {
        public IWebElement TextBoxOldPasswordButton => _driver.FindElement(By.XPath(@"//input[@name=""oldPassword""]"));
        public IWebElement TextBoxNewPasswordButton => _driver.FindElement(By.XPath(@"//input[@name=""newPassword""]"));
        public IWebElement TextBoxRepeatNewPasswordButton => _driver.FindElement(By.XPath(@"//input[@name=""newPasswordRepeat""]"));
        public IWebElement SaveButton => _driver.FindElement(By.XPath(@"//button[@class=""sc-bczRLJ iJvUkY btn btn-fill flex-container""]"));

        public override void Open()
        {
            _driver.Navigate().GoToUrl(@"https://piter-education.ru:7074/change-password");
        }

        public void EnterOldPassword(string oldpassword)
        {
            TextBoxOldPasswordButton.SendKeys(oldpassword);
        }

        public void EnterNewPassword(string newpassword)
        {
            TextBoxNewPasswordButton.SendKeys(newpassword);
        }

        public void EnterRepeatNewPassword(string repeatnewpassword)
        {
            TextBoxRepeatNewPasswordButton.SendKeys(repeatnewpassword);
        }

        public void ClickSaveButton()
        {
            SaveButton.Click();
        }
    }
}
