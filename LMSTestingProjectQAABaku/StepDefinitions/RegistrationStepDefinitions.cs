using LMSTestingProjectQAABaku.Models;
using OpenQA.Selenium.Interactions;
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
            var t = table.CreateSet<RegistrationRequestModel>().ToList();

            string xpacthSurname = @"/html/body/div/div/main/div[1]/form/div[1]/input";
            IWebElement buttonSurname = _driver.FindElement(By.XPath(xpacthSurname));
            buttonSurname.SendKeys(t[0].Surname);

            string xpacthName = @"/html/body/div/div/main/div[1]/form/div[2]/div[1]/input";
            IWebElement buttonName = _driver.FindElement(By.XPath(xpacthName));
            buttonName.SendKeys(t[0].Name);

            string xpacthPatronymic = @"/html/body/div/div/main/div[1]/form/div[2]/div[2]/input";
            IWebElement buttonPatronymic = _driver.FindElement(By.XPath(xpacthPatronymic));
            buttonPatronymic.SendKeys(t[0].Patronymic);

            string xpacthBirthDate = @"/html/body/div/div/main/div[1]/form/div[3]/div/div/div[1]/div/input";
            IWebElement buttonBirthDate = _driver.FindElement(By.XPath(xpacthBirthDate));
            Actions action = new Actions(_driver);
            action.DoubleClick(buttonBirthDate).Perform();
            buttonBirthDate.SendKeys(Keys.Backspace);
            //buttonBirthDate.SendKeys(Keys.Delete);           
            buttonBirthDate.SendKeys(t[0].BirthDate);

            string xpacthPassword = @"/html/body/div/div/main/div[1]/form/div[4]/div[1]/input";
            IWebElement buttonPassword = _driver.FindElement(By.XPath(xpacthPassword));
            buttonPassword.SendKeys(t[0].Password);

            string xpacthRepeatPassword = @"/html/body/div/div/main/div[1]/form/div[4]/div[2]/input";
            IWebElement buttonRepeatPassword = _driver.FindElement(By.XPath(xpacthRepeatPassword));
            buttonRepeatPassword.SendKeys(t[0].RepeatPassword);

            string xpacthEmail = @"/html/body/div/div/main/div[1]/form/div[5]/div[1]/input";
            IWebElement buttonEmail = _driver.FindElement(By.XPath(xpacthEmail));
            buttonEmail.SendKeys(t[0].Email);

            string xpacthPhone = @"/html/body/div/div/main/div[1]/form/div[5]/div[2]/input";
            IWebElement buttonPhone = _driver.FindElement(By.XPath(xpacthPhone));
            buttonPhone.SendKeys(t[0].Phone);

        }

        [When(@"Click the ""([^""]*)"" button")]
        public void WhenClickTheButton(string зарегистрироваться)
        {
            string xpacth = @"/html/body/div/div/main/div[1]/form/div[6]/button[1]";
            IWebElement button = _driver.FindElement(By.XPath(xpacth));
            button.Click();
        }

        [Then(@"Registered user can log in")]
        public void ThenRegisteredUserCanLogIn()
        {
            throw new PendingStepException();
        }

        [When(@"Click to the ""([^""]*)"" button")]
        public void WhenClickToTheButton1(string вход)
        {
            throw new PendingStepException();
        }

        [When(@"Fill the auth form")]
        public void WhenFillTheAuthForm(Table table)
        {
            throw new PendingStepException();
        }

        [When(@"Click  to ""([^""]*)"" button")]
        public void WhenClickToButton(string войти)
        {
            throw new PendingStepException();
        }

        [Then(@"Get user account page")]
        public void ThenGetUserAccountPage()
        {
            throw new PendingStepException();
        }
    }
}
