using LMSTestingProjectQAABaku.Drivers;
using LMSTestingProjectQAABaku.Models;
using LMSTestingProjectQAABaku.Pages;
using TechTalk.SpecFlow.Assist;

namespace LMSTestingProjectQAABaku.StepDefinitions
{
    [Binding]
    public class RegistrationStepDefinitions
    {
        RegistrationPage _registrationPage;

        public RegistrationStepDefinitions()
        {
            _registrationPage = new RegistrationPage();
        }

        [Given(@"We enter the text of the site into search bar and click enter")]
        public void GivenWeEnterTheTextOfTheSiteIntoSearchBarAndClickEnter()
        {
            DriverStorage storage = DriverStorage.Get();
            _registrationPage.Open();
            _registrationPage.GetCertificateOfSafety();
        }

        [When(@"Click to  the ""([^""]*)"" button")]
        public void WhenClickToTheButton(string регистрация)
        {
            _registrationPage.ClickRegistrationButton();
        }

        [When(@"Fill the regist form")]
        public void WhenFillTheRegistForm(Table table)
        {
            var requestTable = table.CreateInstance<RegistrationRequestModel>();

            _registrationPage.EnterSurnameInField(requestTable.Surname);
            _registrationPage.EnterNameInField(requestTable.Name);
            _registrationPage.EnterPatronymicInField(requestTable.Patronymic);            
            _registrationPage.EnterBirthDateInField(requestTable.BirthDate);
            _registrationPage.EnterPasswordInField(requestTable.Password);
            _registrationPage.EnterRepeatPasswordInField(requestTable.RepeatPassword);            
            _registrationPage.EnterEmailInField(requestTable.Email);
            _registrationPage.EnterPhoneInField(requestTable.Phone);
        }

        [When(@"Click to checkbox button")]
        public void WhenClickToCheckboxButton()
        {
            _registrationPage.ClickCheckBox();
        }

        [When(@"Click the ""([^""]*)"" button")]
        public void WhenClickTheButton(string зарегистрироваться)
        {
            _registrationPage.ClickRegistrationButton();
            Thread.Sleep(500);
        }

        [Then(@"I should be notified ""([^""]*)""")]
        public void ThenIShouldBeNotified(string expected)
        {
            string actual = _registrationPage.GetTextNotification();
            Assert.Equal(expected, actual);
        }
    }
}
