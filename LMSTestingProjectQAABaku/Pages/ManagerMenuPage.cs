using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSTestingProjectQAABaku.Pages
{
    public class ManagerMenuPage: AbstractPage
    {
        public IWebElement ButtonForCreateGroup => _driver.FindElement(By.XPath(@"//span[text()='Создать группу']"));
        public IWebElement ButtonForGroupList => _driver.FindElement(By.XPath(@"//span[text()='Группы']"));

        public override void Open()
        {
            //_driver.Navigate().GoToUrl("https://piter-education.ru:7074/login");
        }

        public void ClickCreateGroupButton()
        {
            Actions action = new Actions(_driver);
            action.DoubleClick(ButtonForCreateGroup).Build().Perform();
           //uttonForCreateGroup.Click();
        }

        public void ClickGroupButton()
        {
            //Actions action = new Actions(_driver);
            //action.DoubleClick(ButtonForGroupList).Build().Perform();
            ButtonForGroupList.Click();
        }
    }
}
