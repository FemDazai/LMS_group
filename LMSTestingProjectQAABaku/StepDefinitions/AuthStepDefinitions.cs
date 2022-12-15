using System;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using LMSTestingProjectQAABaku.Models;
using LMSTestingProjectQAABaku.Drivers;
using LMSTestingProjectQAABaku.Pages;
using static System.Net.Mime.MediaTypeNames;
using LMSTestingProjectQAABaku.Pages;

namespace LMSTestingProjectQAABaku.StepDefinitions
{
    [Binding]
    public class AuthStepDefinitions
    {
        AuthPage _authPage;

        public AuthStepDefinitions()
        {
           _authPage = new AuthPage();
        }

        [Given(@"Open auth web page")]
        public void GivenOpenAuthWebPage()
        {
            //DriverStorage storage =  DriverStorage.Get();
            //storage.Driver = new EdgeDriver();
            //storage.Driver.Manage().Window.Maximize();
            //storage.Driver.Navigate().GoToUrl(@"https://piter-education.ru:7074/login");
            _authPage.Open();
            
        }

        [When(@"Fill form")]
        public void WhenFillForm(Table table)
        {
            DriverStorage storage = DriverStorage.Get();
            var _table = table.CreateInstance<AuthModel>();

            //string xpath1 = @"//input[@class='form-input']";//авторизация почта
            //IWebElement textbox1 = storage.Driver.FindElement(By.XPath(xpath1));
            //textbox1.SendKeys(_table.Email);
            _authPage.EnterTextForAuthUser(_table.Email);

            //string xpath2 = @"//input[@class='form-input custom-password']";//авторизация пароль
            //IWebElement textbox2 = storage.Driver.FindElement(By.XPath(xpath2));
            Actions action = new Actions(storage.Driver);
            action.DoubleClick(_authPage.TextBoxPasswordForAuth).Perform();
            _authPage.EnterTextForAuthUser(_table.Password);


        }

        [When(@"Click sign in  button")]
        public void WhenClickSignInButton()
        {
            //DriverStorage storage = DriverStorage.Get();
            //string xpath = @"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']";//кнопка войти авториз
            //IWebElement button = storage.Driver.FindElement(By.XPath(xpath));
            //button.Click();
            //Thread.Sleep(1000);
            _authPage.ClickAuthButton();    
        }

        [Then(@"I shold to see the username ""([^""]*)""")]
        public void ThenISholdToSeeTheUsername(string expected)
        {
            //DriverStorage storage = DriverStorage.Get();
            ////string xpath = @"//span[@class='avatar-name transition-styles']";//имя на акке
            //IWebElement button = storage.Driver.FindElement(By.XPath(xpath));
            string actual = _authPage.GetButtonByName();
            Assert.Equal(expected, actual);
        }
    }
}
