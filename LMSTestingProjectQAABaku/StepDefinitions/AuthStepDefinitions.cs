using System;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using LMSTestingProjectQAABaku.Models;

namespace LMSTestingProjectQAABaku.StepDefinitions
{
    [Binding]
    public class AuthStepDefinitions
    {
        private WebDriver _driver;
        [Given(@"Open auth web page")]
        public void GivenOpenAuthWebPage()
        {
            _driver = new EdgeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(@"https://piter-education.ru:7074/login");
            string xpacth = @"/html/body/div/div[2]/button[3]";
            IWebElement button = _driver.FindElement(By.XPath(xpacth));
            button.Click();
            xpacth = @"/html/body/div/div[3]/p[2]/a";
            button = _driver.FindElement(By.XPath(xpacth));
            button.Click();
        }

        [When(@"Fill form")]
        public void WhenFillForm(Table table)
        {
            var _table = table.CreateInstance<AuthModel>();

            string xpath1 = @"//input[@class='form-input']";//����������� �����
            IWebElement textbox1 = _driver.FindElement(By.XPath(xpath1));
            string xpath2 = @"//input[@class='form-input custom-password']";//����������� ������
            IWebElement textbox2 = _driver.FindElement(By.XPath(xpath2));


            textbox1.SendKeys(_table.Email);
            Actions action = new Actions(_driver);
            action.DoubleClick(textbox2).Perform();
            textbox2.SendKeys(Keys.Backspace);
            textbox2.SendKeys(_table.Password);
        }

        [When(@"Click sign in  button")]
        public void WhenClickSignInButton()
        {
            string xpath = @"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']";//������ ����� �������
            IWebElement button = _driver.FindElement(By.XPath(xpath));
            button.Click();
            Thread.Sleep(1000);
        }

        [Then(@"I shold to see the username ""([^""]*)""")]
        public void ThenISholdToSeeTheUsername(string expected)
        {
            string xpath = @"//span[@class='avatar-name transition-styles']";//��� �� ����
            IWebElement button = _driver.FindElement(By.XPath(xpath));
            string actual = button.Text;
            Assert.Equal(expected, actual);
        }
    }
}
