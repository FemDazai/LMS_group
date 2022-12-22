using LMSTestingProjectQAABaku.Models;
using LMSTestingProjectQAABaku.Cto_to_S_Bekom;
using LMSTestingProjectQAABaku.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using LMSTestingProjectQAABaku.ModelsApi;
using System.Security.Policy;
using LMSTestingProjectQAABaku.Drivers;

namespace LMSTestingProjectQAABaku.StepDefinitions
{
    [Binding]
    public class HomeworkFunctionsStepDefinitions
    {
        WebClient webClient;
        AuthPage _authPage;
        ManagerMenuPage _managerMenuPage;
        TeacherMenuPage _teacherMenuPage;
        StudentPage _studentPage;
        private int _IdTeacher;
        public int IdStudent;
        public int IdTutor;
        public int IdMethodist;

        public HomeworkFunctionsStepDefinitions()
        {
            _authPage = new AuthPage();
            _managerMenuPage = new ManagerMenuPage();
            _teacherMenuPage = new TeacherMenuPage();
            _studentPage = new StudentPage();
        }

        [When(@"Click to button ""([^""]*)""")]
        public void WhenClickToButton(string выйти)
        {
            _managerMenuPage.ClickButtonExit();
            Thread.Sleep(1000);
        }

        [When(@"Auth as teacher")]
        public void WhenAuthAsTeacher()
        {
            _authPage.EnterEmail("pulya@example.com");
            _authPage.EnterPassword("123456789");
            _authPage.ClickAuthButton();
        }

        [When(@"I click ""([^""]*)"" tab")]
        public void WhenIClickTab(string p0)
        {
            _teacherMenuPage.SelectTeacherRole();
            _teacherMenuPage.GetClickButtonHomework();
        }

        [When(@"I click get page for send homework")]
        public void WhenIClickGetPageForSendHomework(Table table)
        {
            _teacherMenuPage.GetClickButtonAddTask();
            var homeworkTable = table.CreateInstance<CreateNewTaskModel>();
            _teacherMenuPage.GetClickButtonSelectGroup();
            _teacherMenuPage.EnterTaskAssignmentDate(homeworkTable.DateOfIssue);
            _teacherMenuPage.EnterTaskDueDate(homeworkTable.DeliveryDate);
            _teacherMenuPage.EnterTaskTitle(homeworkTable.Name);
            _teacherMenuPage.EnterFieldDescriptionTask(homeworkTable.Description);
            _teacherMenuPage.EnterFieldUsefulLinks(homeworkTable.Link);
            _teacherMenuPage.ClickButtonPublish();
        }

        [Then(@"I click ""([^""]*)"" tab and see created homework")]
        public void ThenIClickTabAndSeeCreatedHomework(string p0)
        {
            _teacherMenuPage.GetClickButtonHomework();
        }

        [Given(@"Add homework as teacher")]
        public void GivenAddHomeworkAsTeacher()
        {
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
                gitHubAccount = "github.com/ChuChu",
                phoneNumber = "+72222222223"
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
                gitHubAccount = "github.com/Dazai",
                phoneNumber = "+72222222224"
            };
            int MethodistId = wClient.GetId(requestMethodistApiModel);

            AuthRequestModelApi authRequestModel = new AuthRequestModelApi()
            {
                Email = "marina@example.com",
                Password = "marina123456"
            };
            string actualToken = wClient.Auth(authRequestModel);
            wClient.SetRole(actualToken, Teacherid, "Teacher");
            wClient.SetRole(actualToken, Tyutorid, "Tyutor");
            wClient.SetRole(actualToken, MethodistId, "Methodist");

            CreateGroupeModelApi createGroupeModelApi = new CreateGroupeModelApi()
            {
                name = "string",
                courseId = 1370,
                groupStatusId = "Forming",
                startDate = "22.12.2022",
                endDate = "30.12.2022",
                timetable = "stringstring",
                paymentPerMonth = 10000,
                paymentsCount = 5
            };
            int idGroup = wClient.GetIdCreatedGroup(actualToken, createGroupeModelApi);

            AuthRequestModelApi teacherRequestModel = new AuthRequestModelApi()
            {
                Email = "willywonka@gmail.com",
                Password = "123456789"
            };
            TaskRequestModelApi taskRequestModelApi = new TaskRequestModelApi()
            {
                name = "Команда Б",
                description = "string",
                links = "string",
                isRequired = true,
                groupId = idGroup
            };
            string actualTokenTeacher = wClient.Auth(teacherRequestModel);
            int idTask = wClient.GetIdTask(actualTokenTeacher, taskRequestModelApi);
            int idHomework = wClient.GetCreateHomework(actualTokenTeacher, idGroup, idTask);

            wClient.AddUsers(actualToken, idGroup, Studentid, 6);
            wClient.AddUsers(actualToken, idGroup, Teacherid, 4);
            wClient.AddUsers(actualToken, idGroup, MethodistId, 3);
            wClient.AddUsers(actualToken, idGroup, Tyutorid, 5);
        }
        [Given(@"Log in as student")]
        public void GivenLogInAsStudent()
        {
            _authPage.EnterEmail("rodionraskol@gmail.com");
            _authPage.EnterPassword("123456789");
            _authPage.ClickAuthButton();
        }
        [Given(@"I click ""([^""]*)""")]
        public void GivenIClick(string p0)
        {
            _studentPage.ClickButtonHomeworkStudent();
        }

        [Given(@"Click in button ""([^""]*)""")]
        public void GivenClickInButton(string p0)
        {
            _studentPage.ClickButtonGoToHomeworkPage();
        }

        [When(@"I fill in all the fields in page")]
        public void WhenIFillInAllTheFieldsInPage(Table table)
        {
            var _table = table.CreateInstance<HomeworkGithubField>();
            _studentPage.FillFieldEnterHomeworkLink(_table.LinkGitHub);
        }

        [When(@"Click on send button")]
        public void WhenClickOnSendButton()
        {
            _studentPage.ClickButtonHomeworkLinkSend();
        }

        [When(@"Click to link ""([^""]*)""")]
        public void WhenClickToLink(string p0)
        {
            _studentPage.ClickLinkReadyHomework();
        }

        [Then(@"I have to go to another page")]
        //public void ThenIHaveToGoToAnotherPage()
        //{
        //    DriverStorage storage = DriverStorage.GetInstance();
        //    string expected = Urls.HomePage;
        //    string actual = storage.Driver.Url;
        //    Assert.AreNotEqual(expected, actual);
        //}

        [Then(@"I should see the status of the completed task as ""([^""]*)""")]
        public void ThenIShouldSeeTheStatusOfTheCompletedTaskAs(string проверить)
        {
            throw new PendingStepException();
        }

    }
}
