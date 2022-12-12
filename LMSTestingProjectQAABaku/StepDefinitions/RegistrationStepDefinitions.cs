using LMSTestingProjectQAABaku.Models;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace LMSTestingProjectQAABaku.StepDefinitions
{
    [Binding]
    public class RegistrationStepDefinitions
    {
        private WebDriver _driver;

        [Given(@"We enter the text of the site into search bar and click enter")]
        public void GivenWeEnterTheTextOfTheSiteIntoSearchBarAndClickEnter()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://piter-education.ru:7074/login");
            string xpacth = @"/html/body/div/div[2]/button[3]";
            IWebElement button = _driver.FindElement(By.XPath(xpacth));
            button.Click();
            xpacth = @"/html/body/div/div[3]/p[2]/a";
            button = _driver.FindElement(By.XPath(xpacth));
            button.Click();
        }

        [When(@"Click to  the ""([^""]*)"" button")]
        public void WhenClickToTheButton(string регистрация)
        {
            string xpacth = @"/html/body/div/div/aside/div/nav/div/a[2]";
            IWebElement button = _driver.FindElement(By.XPath(xpacth));
            button.Click();
        }

        [When(@"Fill the regist form")]
        public void WhenFillTheRegistForm(Table table)
        {
            var requestTable = table.CreateInstance<RegistrationRequestModel>();

            string xpathSurname = @"/html/body/div/div/main/div[1]/form/div[1]/input";
            IWebElement buttonSurname = _driver.FindElement(By.XPath(xpathSurname));
            buttonSurname.SendKeys(requestTable.Surname);

            string xpathName = @"/html/body/div/div/main/div[1]/form/div[2]/div[1]/input";
            IWebElement buttonName = _driver.FindElement(By.XPath(xpathName));
            buttonName.SendKeys(requestTable.Name);

            string xpathPatronymic = @"/html/body/div/div/main/div[1]/form/div[2]/div[2]/input";
            IWebElement buttonPatronymic = _driver.FindElement(By.XPath(xpathPatronymic));
            buttonPatronymic.SendKeys(requestTable.Patronymic);

            string xpathBirthDate = @"/html/body/div/div/main/div[1]/form/div[3]/div/div/div[1]/div/input";
            IWebElement buttonBirthDate = _driver.FindElement(By.XPath(xpathBirthDate));
            Actions action = new Actions(_driver);
            action.DoubleClick(buttonBirthDate).Perform();
            buttonBirthDate.SendKeys(Keys.Backspace);
            //buttonBirthDate.SendKeys(Keys.Delete);           
            buttonBirthDate.SendKeys(requestTable.BirthDate);

            string xpathPassword = @"/html/body/div/div/main/div[1]/form/div[4]/div[1]/input";
            IWebElement buttonPassword = _driver.FindElement(By.XPath(xpathPassword));
            buttonPassword.SendKeys(requestTable.Password);

            string xpathRepeatPassword = @"/html/body/div/div/main/div[1]/form/div[4]/div[2]/input";
            IWebElement buttonRepeatPassword = _driver.FindElement(By.XPath(xpathRepeatPassword));
            buttonRepeatPassword.SendKeys(requestTable.RepeatPassword);

            string xpathEmail = @"/html/body/div/div/main/div[1]/form/div[5]/div[1]/input";
            IWebElement buttonEmail = _driver.FindElement(By.XPath(xpathEmail));
            buttonEmail.SendKeys(requestTable.Email);

            string xpathPhone = @"/html/body/div/div/main/div[1]/form/div[5]/div[2]/input";
            IWebElement buttonPhone = _driver.FindElement(By.XPath(xpathPhone));
            buttonPhone.SendKeys(requestTable.Phone);

        }

        [When(@"Click to checkbox button")]
        public void WhenClickToCheckboxButton()
        {
            IWebElement button = _driver.FindElement(By.XPath($"//*[@class='custom-checkbox']"));
            button.Click();;
        }

        [When(@"Click the ""([^""]*)"" button")]
        public void WhenClickTheButton(string зарегистрироваться)
        {
            string xpacth = @"/html/body/div/div/main/div[1]/form/div[6]/button[1]";
            IWebElement button = _driver.FindElement(By.XPath(xpacth));
            button.Click();
            Thread.Sleep(1000);

        }

        [Then(@"I should be notified ""([^""]*)""")]
        public void ThenIShouldBeNotified(string expected)
        {
            string xpacth = @"/html/body/div/div/main/div[2]/div/p";
            IWebElement button = _driver.FindElement(By.XPath(xpacth));
            //IWebElement textBox = _driver.FindElement(By.XPath(@"/html/body/div/div/main/div[2]/div"));
            string actual = button.Text;
            Assert.Equal(expected, actual);
            //_driver.implicitly_wait(10)
        }
    }
}
