using TechTalk.SpecFlow.Assist;
using LMSTestingProjectQAABaku.Models;
using LMSTestingProjectQAABaku.Pages;
using static System.Net.Mime.MediaTypeNames;
using LMSTestingProjectQAABaku.Drivers;

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
            _authPage.Open();
            _authPage.GetCertificateOfSafety();
            Thread.Sleep(1000);
        }

        [When(@"Fill form")]
        public void WhenFillForm(Table table)
        {
            var _table = table.CreateInstance<AuthModel>();
            _authPage.EnterEmail(_table.Email);
            _authPage.EnterPassword(_table.Password);
        }

        [When(@"Click sign in  button")]
        public void WhenClickSignInButton()
        {
            _authPage.ClickAuthButton();    
        }

        [Then(@"I shold to see the username ""([^""]*)""")]
        public void ThenISholdToSeeTheUsername(string expected)
        {
            string actual = _authPage.GetButtonByName();
            Assert.Equal(expected, actual);
        }

        [Given(@"Fill  form")]
        public void GivenFillForm(Table table)
        {
            var _table = table.CreateInstance<AuthModel>();
            _authPage.EnterEmail(_table.Email);
            _authPage.EnterPassword(_table.Password);
        }

        [Then(@"I stay on the login  page")]
        public void ThenIStayOnTheLoginPage()
        {
            DriverStorage storage = DriverStorage.Get();
            string expected = "https://piter-education.ru:7074/login";
            string actual = storage.Driver.Url;
            Assert.Equal(expected, actual);
        }

        [Then(@"I shold to see  the notification ""([^""]*)""")]
        public void ThenISholdToSeeTheNotification(string expected)
        {
            string actual = _authPage.GetNotificationWrongPassword();
            Assert.Equal(expected, actual);
        }

        [Given(@"Fill form")]
        public void FillFormWithWrongEmail(Table table)
        {
            var _table = table.CreateInstance<AuthModel>();
            _authPage.EnterEmail(_table.Email);
            _authPage.EnterPassword(_table.Password);
        }

        [Then(@"I shold to see  the notification  ""([^""]*)""")]
        public void ThenISholdToSeeTheNotifications(string expected)
        {
            string actual = _authPage.GetNotificationWrongEmail();
            Assert.Equal(expected, actual);
        }
    }
}
