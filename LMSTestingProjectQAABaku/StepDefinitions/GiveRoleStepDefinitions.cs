using LMSTestingProjectQAABaku.Models;
using LMSTestingProjectQAABaku.ModelsApi;
using LMSTestingProjectQAABaku.Pages;

namespace LMSTestingProjectQAABaku.StepDefinitions
{
    [Binding]
    public class GiveRoleStepDefinitions
    {
        AuthPage _authPage;
        TeacherMenuPage _teacherMenuPage;

        public GiveRoleStepDefinitions()
        { 
            _authPage = new AuthPage();
            _teacherMenuPage = new TeacherMenuPage();
        }

        [Given(@"Request  as student")]
        public void GivenRequestAsStudent()
        {
            _authPage.Open();
            _authPage.GetCertificateOfSafety();
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
            _authPage.EnterEmail("willywonka@gmail.com");
            _authPage.EnterPassword("123456789");
        }

        [When(@"Click button ""([^""]*)""")]
        public void WhenClickButton(string войти)
        {
            _authPage.ClickAuthButton();
            Thread.Sleep(1000);
        }

        [When(@"Click to the role button")]
        public void WhenClickToTheRoleButton()
        {
            _teacherMenuPage.GetClickButtonUserNameMenu();
        }

        [When(@"Click to  the button teacher")]
        public void WhenClickToTheButtonTeacher()
        {
            _teacherMenuPage.GetClickButtonSelectTeacher();
        }

        [Then(@"I  should to see my name")]
        public void ThenIShouldToSeeMyName()
        {
            string expected = "Вилли";
            string actual = _teacherMenuPage.GetTextButtonAvatarName();
            Assert.Equal(expected, actual);
        }

        [Then(@"I  should to see my role")]
        public void ThenIShouldToSeeMyRole()
        {
            string expected = "Преподаватель";
            string actual = _teacherMenuPage.GetTextButtonAvatarRole();
            Assert.Equal(expected, actual);
        }
    }
}
