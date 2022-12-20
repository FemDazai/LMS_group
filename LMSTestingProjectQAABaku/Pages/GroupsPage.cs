using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSTestingProjectQAABaku.Pages
{
    public class GroupsPage: AbstractPage
    {
        public IWebElement ButtonGroupNameTitle => _driver.FindElement(By.XPath(@"//div[@class='tab-item active-tab']"));

        public override void Open()
        {
            _driver.Navigate().GoToUrl("https://piter-education.ru:7074/login");
        }

        public void ButtonGroupName()
        {
            ButtonGroupNameTitle.Click();
        }
     
    }
}
