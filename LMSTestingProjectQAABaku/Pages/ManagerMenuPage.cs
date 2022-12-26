using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSTestingProjectQAABaku.Pages
{
    public class ManagerMenuPage: AbstractPage
    {
        //public IWebElement ButtonForCreateGroup => _driver.FindElement(By.XPath(@"//span[text()='Создать группу']"))
        public IWebElement ButtonForCreateGroup
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//span[text()='Создать группу']")));
            }
        }
        public IWebElement ButtonForGroupList => _driver.FindElement(By.XPath(@"//span[text()='Группы']"));
        public IWebElement ButtonExit => _driver.FindElement(By.XPath(@"//button[@class='exit flex-center']"));
        public IWebElement ButtonSelectAdmin => _driver.FindElement(By.XPath(@"//li[text()='Администратор'][1]"));
        //public IWebElement ButtonSelectCourse => _driver.FindElement(By.XPath(@"//div[@class='drop-down-filter  ']"));
        public IWebElement ButtonSelectCourse
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"//li[text()='Администратор'][1]")));
            }
        }
        public IWebElement ButtonSelectCourseFrontend => _driver.FindElement(By.XPath(@"//div[text()='FrontedCourse']"));

        public override void Open()
        {
            _driver.Navigate().GoToUrl("https://piter-education.ru:7074/login");
        }

        public void GetClickButtonSelectAdmin()
        {
            ButtonSelectAdmin.Click();
        }
        public void GetClickButtonSelectCourse()
        {
            ButtonSelectCourse.Click();
        }

        public void ClickCreateGroupButton()
        {
            Actions action = new Actions(_driver);
            action.DoubleClick(ButtonForCreateGroup).Build().Perform();
           //uttonForCreateGroup.Click();
        }

        public void ClickGroupButton()
        {
            Actions action = new Actions(_driver);
            action.DoubleClick(ButtonForGroupList).Build().Perform();
            ButtonForGroupList.Click();
        }

        public void ClickButtonExit()
        {
            ButtonExit.Click();
        }
    }
}
