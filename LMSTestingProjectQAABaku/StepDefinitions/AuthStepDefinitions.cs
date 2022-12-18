using TechTalk.SpecFlow.Assist;
using LMSTestingProjectQAABaku.Models;
using LMSTestingProjectQAABaku.Pages;
using static System.Net.Mime.MediaTypeNames;

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
    }
}
