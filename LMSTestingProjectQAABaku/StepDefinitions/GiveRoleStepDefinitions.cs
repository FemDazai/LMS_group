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
            string xpathEmail = $"/html/body/div/div/main/div[1]/form/div[1]/input";
            IWebElement textbox1 = _driver.FindElement(By.XPath(xpathEmail));
            string xpathPassword = $"/html/body/div/div/main/div[1]/form/div[2]/input";
            IWebElement textbox2 = _driver.FindElement(By.XPath(xpathPassword));

            textbox1.SendKeys("willywonka@gmail.com");
            Actions action = new Actions(_driver);
            action.DoubleClick(textbox2).Perform();
            textbox2.SendKeys(Keys.Backspace);
            textbox2.SendKeys("123456789");
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
            string xpacth = @"/html/body/div/div/aside/div/div[1]/div[2]/div/div/div/div";
            IWebElement button2 = _driver.FindElement(By.XPath(xpacth));
            button2.Click();
        }

        [When(@"Click to  the button teacher")]
        public void WhenClickToTheButtonTeacher()
        {
            string xpacth = @"/html/body/div/div/aside/div/div[1]/div[2]/div/div/div/div[2]/ul/li[2]";
            IWebElement button = _driver.FindElement(By.XPath(xpacth));
            button.Click();
        }

        [Then(@"I  should to see my name")]
        public void ThenIShouldToSeeMyName()
        {
            string expected = "Вилли";

            string xpath = @"/html/body/div/div/aside/div/div[1]/div[2]/div/a/span[2]";
            IWebElement NameBox = _driver.FindElement(By.XPath(xpath));
            string actual = NameBox.Text;
            Assert.Equal(expected, actual);
        }

        [Then(@"I  should to see my role")]
        public void ThenIShouldToSeeMyRole()
        {
            string expected = "Преподаватель";
            string xpath = @"/html/body/div/div/aside/div/div[1]/div[2]/div/div/div/div[1]";
            IWebElement RoleBox = _driver.FindElement(By.XPath(xpath));
            string actual = RoleBox.Text;
            Assert.Equal(expected, actual);
        }
    }
}
