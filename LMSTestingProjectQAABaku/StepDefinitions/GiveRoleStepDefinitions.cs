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
            //_authPage.Open();
            //_authPage.GetCertificateOfSafety();
            WebClient wClient = new WebClient();
            RequestModelApi requestStudentModel = new RequestModelApi()
            {
                firstName = "Родион",
                lastName = "Раскольников",
                patronymic = "Романович",
                email = "rodionraskol@gmail.com",
                username = "Rodion",
                password = "123456789",
                city = "SaintPetersburg",
                birthDate = "15.12.1999",
                gitHubAccount = "github.com/Rodionchik",
                phoneNumber = "+72222222221"
            };
            int Studentid = wClient.GetId(requestStudentModel);
            RequestModelApi requestTeacherApiModel = new RequestModelApi()
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
            int Teacherid = wClient.GetId(requestTeacherApiModel);

            RequestModelApi requestTyutorApiModel = new RequestModelApi()
            {
                firstName = "Чуя",
                lastName = "Накахара",
                patronymic = "Огаев",
                email = "chuchu@gmail.com",
                username = "jenaDazaya",
                password = "123456789",
                city = "SaintPetersburg",
                birthDate = "25.12.1990",
                gitHubAccount = "github.com/JohnnyDepp",
                phoneNumber = "+72222222222"
            };
            int Tyutorid = wClient.GetId(requestTyutorApiModel);

            RequestModelApi requestMethodistApiModel = new RequestModelApi()
            {
                firstName = "Дазай",
                lastName = "Осаму",
                patronymic = "Одавич",
                email = "dazai@gmail.com",
                username = "chuyamilaxa",
                password = "123456789",
                city = "SaintPetersburg",
                birthDate = "15.12.1980",
                gitHubAccount = "github.com/JohnnyDepp",
                phoneNumber = "+72222222222"
            };
            int Methodistid = wClient.GetId(requestMethodistApiModel);

            AuthRequestModelApi authRequestModel = new AuthRequestModelApi()
            {
                Email = "marina@example.com",
                Password = "marina123456"
            };
            string actualToken = wClient.Auth(authRequestModel);
            wClient.SetRole(actualToken, Teacherid, "Teacher");
            wClient.SetRole(actualToken, Tyutorid, "Tyutor");
            wClient.SetRole(actualToken, Methodistid, "Methodist");
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
