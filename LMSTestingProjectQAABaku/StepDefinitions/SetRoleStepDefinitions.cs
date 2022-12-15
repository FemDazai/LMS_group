using LMSTestingProjectQAABaku.Models;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow.Assist;

namespace LMSTestingProjectQAABaku.StepDefinitions
{
    [Binding]
    public class SetRoleStepDefinitions
    {
        private WebDriver _driver;
        [Given(@"Registration as student")]
        public void GivenRegistrationAsStudent()
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

            //string xpacth1 = @"/html/body/div/div/aside/div/nav/div/a[2]";
            //IWebElement button1 = _driver.FindElement(By.XPath(xpacth1));
            //button1.Click();

            //string xpathSurname = @"/html/body/div/div/main/div[1]/form/div[1]/input";
            //IWebElement buttonSurname = _driver.FindElement(By.XPath(xpathSurname));
            //buttonSurname.SendKeys("Иванова");

            //string xpathName = @"/html/body/div/div/main/div[1]/form/div[2]/div[1]/input";
            //IWebElement buttonName = _driver.FindElement(By.XPath(xpathName));
            //buttonName.SendKeys("Галина");

            //string xpathPatronymic = @"/html/body/div/div/main/div[1]/form/div[2]/div[2]/input";
            //IWebElement buttonPatronymic = _driver.FindElement(By.XPath(xpathPatronymic));
            //buttonPatronymic.SendKeys("Ивановна");

            //string xpathBirthDate = @"/html/body/div/div/main/div[1]/form/div[3]/div/div/div[1]/div/input";
            //IWebElement buttonBirthDate = _driver.FindElement(By.XPath(xpathBirthDate));
            //Actions action = new Actions(_driver);
            //action.DoubleClick(buttonBirthDate).Perform();
            //buttonBirthDate.SendKeys(Keys.Backspace);
            ////buttonBirthDate.SendKeys(Keys.Delete);           
            //buttonBirthDate.SendKeys("01.10.1980");

            //string xpathPassword = @"/html/body/div/div/main/div[1]/form/div[4]/div[1]/input";
            //IWebElement buttonPassword = _driver.FindElement(By.XPath(xpathPassword));
            //buttonPassword.SendKeys("123456789");

            //string xpathRepeatPassword = @"/html/body/div/div/main/div[1]/form/div[4]/div[2]/input";
            //IWebElement buttonRepeatPassword = _driver.FindElement(By.XPath(xpathRepeatPassword));
            //buttonRepeatPassword.SendKeys("123456789");

            //string xpathEmail = @"/html/body/div/div/main/div[1]/form/div[5]/div[1]/input";
            //IWebElement buttonEmail = _driver.FindElement(By.XPath(xpathEmail));
            //buttonEmail.SendKeys("galinaivanovna2@gmail.com");

            //string xpathPhone = @"/html/body/div/div/main/div[1]/form/div[5]/div[2]/input";
            //IWebElement buttonPhone = _driver.FindElement(By.XPath(xpathPhone));
            //buttonPhone.SendKeys("+7123456789");

            //IWebElement buttonCheckBox = _driver.FindElement(By.XPath($"//*[@class='custom-checkbox']"));
            //buttonCheckBox.Click();

            //string xpathRequest = @"/html/body/div/div/main/div[1]/form/div[6]/button[1]";
            //IWebElement buttonRequest = _driver.FindElement(By.XPath(xpathRequest));
            //buttonRequest.Click();
            //Thread.Sleep(1000);
        }

        [When(@"Click  the button ""([^""]*)""")]
        public void WhenClickTheButton()
        {

            WebClient wClient = new WebClient();

            AuthRequestModelApi authRequestModel = new AuthRequestModelApi()
            {
                Email = "marina@example.com",
                Password = "marina123456"
            };
            string actualToken = wClient.Auth(authRequestModel);
            wClient.SetRole(actualToken, 18991, "Teacher");
        }

        [When(@"Auth as teacher")]
        public void WhenAuthAsTeacher()
        {
            string xpath = @"/html/body/div/div/aside/div/nav/div/a[1]";
            IWebElement button = _driver.FindElement(By.XPath(xpath));
            button.Click();

            string xpathEmail = @"/html/body/div/div/main/div[1]/form/div[1]/input";
            IWebElement textbox1 = _driver.FindElement(By.XPath(xpathEmail));
            string xpathPassword = @"/html/body/div/div/main/div[1]/form/div[2]/input";
            IWebElement textbox2 = _driver.FindElement(By.XPath(xpathPassword));

            textbox1.SendKeys("galinaivanovna2@gmail.com");
            Actions action = new Actions(_driver);
            action.DoubleClick(textbox2).Perform();
            textbox2.SendKeys(Keys.Backspace);
            textbox2.SendKeys("123456789"); 

            string xpath1 = @"/html/body/div/div/main/div[1]/form/div[3]/button[1]";
            IWebElement button1 = _driver.FindElement(By.XPath(xpath1));
            button1.Click();
            Thread.Sleep(1000);
        }

        [When(@"Click to  the role button")]
        public void WhenClickToTheRoleButton()
        {
            string xpacth = "/html/body/div/div/aside/div/div[1]/div[2]/div/div/div";
            IWebElement button = _driver.FindElement(By.XPath(xpacth));
            button.Click();
        }

        [When(@"Click to the button teacher")]
        public void WhenClickToTheButtonTeacher()
        {
            string xpacth = "/html/body/div/div/aside/div/div[1]/div[2]/div/div/div/div[2]/ul/li[2]";
            IWebElement button = _driver.FindElement(By.XPath(xpacth));
            button.Click();
        }

        [Then(@"I should to see my name")]
        public void ThenIShouldToSeeMyName()
        {
            string expected = "Галина";

            string xpath = @"/html/body/div/div/aside/div/div[1]/div[2]/div/a/span[2]";
            IWebElement NameBox = _driver.FindElement(By.XPath(xpath));
            string actual = NameBox.Text;
            Assert.Equal(expected, actual);
        }

        [Then(@"I should to see my role")]
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
