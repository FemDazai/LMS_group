using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSTestingProjectQAABaku.Pages
{
    public class MethodistMenuPage: AbstractPage
    {
        public IWebElement ButtonCourses => _driver.FindElement(By.XPath(@"//span[text()='Курсы']"));
        public IWebElement ButtonEditCourses => _driver.FindElement(By.XPath(@"//span[text()='Редактировать курсы']"));
        public IWebElement ButtonSelectMethodist => _driver.FindElement(By.XPath(@"//li[text()='Методист'][1]"));

        public override void Open()
        {
            _driver.Navigate().GoToUrl("https://piter-education.ru:7074/login");
        }

        public void ClickButtonCourses()
        {
            ButtonCourses.Click();
        }

        public void ClickButtonEditCourses()
        {
            ButtonEditCourses.Click();
        }

        public void ClickButtonSelectMethodist()
        {
            ButtonSelectMethodist.Click();
        }
    }
}
