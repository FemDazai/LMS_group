using LMSTestingProjectQAABaku.Models;
using LMSTestingProjectQAABaku.ModelsApi;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;

namespace LMSTestingProjectQAABaku.StepDefinitions
{
    [Binding]
    public class GiveRoleStepDefinitions
    {
        private WebDriver _driver;
        [Given(@"Request  as student")]
        public void GivenRequestAsStudent()
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
            WebClient wClient = new WebClient();
            RequestModelApi requestUserApiModel = new RequestModelApi()
            {
                firstName = "Вилли",
                lastName = "Вонка",
                patronymic = "ОтецВиллиВонка",
                email = "willywonka@gmail.com",
                username = "willy",
                password = "123456789",
                city = "SaintPetersburg",
                birthDate = "15.12.1980",
                gitHubAccount = "github.com/JohnnyDepp",
                phoneNumber = "+72222222222"
            };
            int id = wClient.GetId(requestUserApiModel);
            AuthRequestModelApi authRequestModel = new AuthRequestModelApi()
            {
                Email = "marina@example.com",
                Password = "marina123456"
            };
            string actualToken = wClient.Auth(authRequestModel);
            wClient.SetRole(actualToken, id, "Teacher");
        }    

        [When(@"Auth  as teacher")]
        public void WhenAuthAsTeacher()
        {
            string xpathEmail = $"//input[@class='form-input']";
            IWebElement textboxEmail = _driver.FindElement(By.XPath(xpathEmail));
            string xpathPassword = $"//input[@class='form-input custom-password']";
            IWebElement textboxPassword = _driver.FindElement(By.XPath(xpathPassword));

            textboxEmail.SendKeys("willywonka@gmail.com");
            Actions action = new Actions(_driver);
            action.DoubleClick(textboxPassword).Perform();
            textboxPassword.SendKeys(Keys.Backspace);
            textboxPassword.SendKeys("123456789");
        }

        [When(@"Click button ""([^""]*)""")]
        public void WhenClickButton(string войти)
        {
            string xpath1 = @"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']";
            IWebElement button = _driver.FindElement(By.XPath(xpath1));
            button.Click();
            Thread.Sleep(1000);
        }

        [When(@"Click to the role button")]
        public void WhenClickToTheRoleButton()
        {
            string xpacth = @"//div[@class='drop-down-filter__wrapper']";
            IWebElement button2 = _driver.FindElement(By.XPath(xpacth));
            button2.Click();
        }

        [When(@"Click to  the button teacher")]
        public void WhenClickToTheButtonTeacher()
        {
            string xpacth = @"//li[text()='Преподаватель'][1]";
            IWebElement button = _driver.FindElement(By.XPath(xpacth));
            button.Click();
        }

        [Then(@"I  should to see my name")]
        public void ThenIShouldToSeeMyName()
        {
            string expected = "Вилли";

            string xpath = @"//span[@class='avatar-name transition-styles']";
            IWebElement NameBox = _driver.FindElement(By.XPath(xpath));
            string actual = NameBox.Text;
            Assert.Equal(expected, actual);
        }

        [Then(@"I  should to see my role")]
        public void ThenIShouldToSeeMyRole()
        {
            string expected = "Преподаватель";
            string xpath = @"//div[text()='Преподаватель']";
            IWebElement RoleBox = _driver.FindElement(By.XPath(xpath));
            string actual = RoleBox.Text;
            Assert.Equal(expected, actual);
        }
    }
}
