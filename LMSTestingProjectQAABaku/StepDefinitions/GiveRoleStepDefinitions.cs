using LMSTestingProjectQAABaku.ModelsApi;
using LMSTestingProjectQAABaku.Pages;

namespace LMSTestingProjectQAABaku.StepDefinitions
{
    [Binding]
    public class GiveRoleStepDefinitions
    {
        AuthPage _authPage;
        TeacherMenuPage _teacherMenuPage;
        WebClient _webClient;
        private int _idStudent;
        public GiveRoleStepDefinitions()
        { 
            _authPage = new AuthPage();
            _teacherMenuPage = new TeacherMenuPage();
            _webClient = new WebClient();
        }

        [Given(@"Request  as student")]
        public void GivenRequestAsStudent()
        {
            RequestModelApi requestStudentforGiveRole = DataMock.requestStudentModelWeb;
            IdStorage.CreateInstance().studentId = _webClient.GetUserId(requestStudentforGiveRole);
            _idStudent = IdStorage.CreateInstance().studentId;
        }

        [When(@"Auth  as teacher")]
        public void WhenAuthAsTeacher()
        {
            _authPage.EnterEmail("willywonka30@gmail.com");
            _authPage.EnterPassword("123456789");
        }

        [When(@"Click button ""([^""]*)""")]
        public void WhenClickButton(string войти)
        {
            _authPage.ClickAuthButton();
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
