using System;
using LMSTestingProjectQAABaku.Pages;
using System.Configuration;
using TechTalk.SpecFlow;
using LMSTestingProjectQAABaku.Models;
using TechTalk.SpecFlow.Assist;

namespace LMSTestingProjectQAABaku.StepDefinitions
{
    [Binding]
    public class ChangePhotoStepDefinitions
    {
        AuthPage _authPage;
        SettingsPage _settingsPage;
        ChangePasswordPage _changePasswordPage;
        public ChangePhotoStepDefinitions()
        {
            _authPage = new AuthPage();
            _settingsPage = new SettingsPage();
            _changePasswordPage = new ChangePasswordPage();
        }
        [Given(@"Open  auth web page")]
        public void GivenOpenAuthWebPage()
        {
            _authPage.Open();
            _authPage.GetCertificateOfSafety();
            Thread.Sleep(1000);
        }

        [When(@"Fill auth form")]
        public void WhenFillAuthForm(Table table)
        {
            var _table = table.CreateInstance<AuthModel>();
            _authPage.EnterEmail(_table.Email);
            //_authPage.DeletePassword();
            _authPage.EnterPassword(_table.Password);
        }

        [When(@"Click ""([^""]*)""  button")]
        public void WhenClickButton(string войти)
        {
            _authPage.ClickAuthButton();
        }

        [When(@"Click on profile picture")]
        public void WhenClickOnProfilePicture()
        {
            _authPage.ClickOnPicture();
        }

        [When(@"Where the password caption click on the pen icon")]
        public void WhenWhereThePasswordCaptionClickOnThePenIcon()
        {
            _settingsPage.ClickButtonWithPenIcon();
        }

        [When(@"Fill  form")]
        public void WhenFillForm(Table table)
        {
            var _table = table.CreateInstance<ChangePasswordModel>();
            _changePasswordPage.EnterOldPassword(_table.OldPassword);
            _changePasswordPage.EnterNewPassword(_table.NewPassword);
            _changePasswordPage.EnterRepeatNewPassword(_table.RepeatNewPassword);
        }

        [When(@"Click on the ""([^""]*)"" button")]
        public void WhenClickOnTheButton(string сохранить)
        {
            _changePasswordPage.ClickSaveButton();
        }

        [Then(@"I should see the username ""([^""]*)""")]
        public void ThenIShouldSeeTheUsername(string expected)
        {
            string actual = _authPage.GetButtonByName();
            Assert.Equal(expected, actual);
        }
    }
}
