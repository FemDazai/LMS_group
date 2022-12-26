using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LMSTestingProjectQAABaku.Pages
{
    public class SettingsPage : AbstractPage
    {
        public IWebElement ButtonWithPenIcon => _driver.FindElement(By.XPath($"//a[@href=\"/change-password\"]"));
        public IWebElement ButtonIcon => _driver.FindElement(By.XPath($"//div[@class='svg-fond']"));
        public override void Open()
        {
            _driver.Navigate().GoToUrl(@"https://piter-education.ru:7074/settings");
        }
        public void ClickButtonWithPenIcon()
        {
            ButtonWithPenIcon.Click();
        }
        public void ClickButtonIcon()
        {
            ButtonIcon.Click();
        }
    }
}
