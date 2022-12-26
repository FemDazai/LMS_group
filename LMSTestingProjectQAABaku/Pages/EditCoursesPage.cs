using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSTestingProjectQAABaku.Pages
{
    public class EditCoursesPage: AbstractPage
    {
        public IWebElement TextBoxTopicNumber=> _driver.FindElement(By.XPath(@"//input[@placeholder='0']"));
        public IWebElement TextBoxTopicName => _driver.FindElement(By.XPath(@"//input[@placeholder='Введите текст']"));
        public IWebElement TextBoxDuration => _driver.FindElement(By.XPath(@"//input[@placeholder='XX']"));
        public IWebElement ButtonForSaveTopic => _driver.FindElement(By.XPath(@"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']"));

        public override void Open()
        {
        _driver.Navigate().GoToUrl("https://piter-education.ru:7074/login");
        }

        public void EnterNumber(string text)
        {
            TextBoxTopicNumber.SendKeys(text);
        }

        public void EnterTopicName(string text)
        {
            TextBoxTopicName.SendKeys(text);
        }

        public void EnterDuration(string text)
        {
            TextBoxDuration.SendKeys(text);
        }

        public void ClickSaveButton()
        {
            ButtonForSaveTopic.Click();
        }

    }
}

