using LMSTestingProjectQAABaku.Models;
using LMSTestingProjectQAABaku.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using LMSTestingProjectQAABaku.ModelsApi;
using System.Security.Policy;
using LMSTestingProjectQAABaku.Drivers;
using System.Net;

namespace LMSTestingProjectQAABaku.StepDefinitions
{
    [Binding]
    public class HomeworkFunctionsStepDefinitions
    {
        WebClient _webClient;
        AuthPage _authPage;
        ManagerMenuPage _managerMenuPage;
        TeacherMenuPage _teacherMenuPage;
        StudentPage _studentPage;
        private int _idTeacher;
        public int _idStudent;
        public int _idTutor;
        public int _idMethodist;
        public string _adminToken;
        public string _teacherToken;
        private int _idCourseBase;
        private int _idCourseFronted;
        private int _idCourseBackend;
        private int _idCourseQAA;
        private int _idGroup;
        private int _idTask;
        private int _idHomework;

        public HomeworkFunctionsStepDefinitions()
        {
            _authPage = new AuthPage();
            _managerMenuPage = new ManagerMenuPage();
            _teacherMenuPage = new TeacherMenuPage();
            _studentPage = new StudentPage();
            _webClient = new WebClient();
        }

        //[When(@"Click to button ""([^""]*)""")]
        //public void WhenClickToButton(string выйти)
        //{
        //    _managerMenuPage.ClickButtonExit();
        //    Thread.Sleep(1000);
        //}

        //[When(@"Auth as teacher")]
        //public void WhenAuthAsTeacher()
        //{
        //    _authPage.EnterEmail("pulya@example.com");
        //    _authPage.EnterPassword("123456789");
        //    _authPage.ClickAuthButton();
        //}

        //[When(@"I click ""([^""]*)"" tab")]
        //public void WhenIClickTab(string p0)
        //{
        //    _teacherMenuPage.SelectTeacherRole();
        //    _teacherMenuPage.GetClickButtonHomework();
        //}

        //[When(@"I click get page for send homework")]
        //public void WhenIClickGetPageForSendHomework(Table table)
        //{
        //    _teacherMenuPage.GetClickButtonAddTask();
        //    var homeworkTable = table.CreateInstance<CreateNewTaskModel>();
        //    _teacherMenuPage.GetClickButtonSelectGroup();
        //    _teacherMenuPage.EnterTaskAssignmentDate(homeworkTable.DateOfIssue);
        //    _teacherMenuPage.EnterTaskDueDate(homeworkTable.DeliveryDate);
        //    _teacherMenuPage.EnterTaskTitle(homeworkTable.Name);
        //    _teacherMenuPage.EnterFieldDescriptionTask(homeworkTable.Description);
        //    _teacherMenuPage.EnterFieldUsefulLinks(homeworkTable.Link);
        //    _teacherMenuPage.ClickButtonPublish();
        //}

        //[Then(@"I click ""([^""]*)"" tab and see created homework")]
        //public void ThenIClickTabAndSeeCreatedHomework(string p0)
        //{
        //    _teacherMenuPage.GetClickButtonHomework();
        //}







        //[Given(@"Add homework as teacher")]
        //public void GivenAddHomeworkAsTeacher()
        //{
        //    WebClient wClient = new WebClient();
        //    RequestModelApi requestStudentModel = DataMock.requestStudentModelRodion;
        //    IdStorage.CreateInstance().studentId = wClient.GetId(requestStudentModel);

        //    RequestModelApi requestTeacherModelApi = DataMock.requestTeacherApiModelWilly;
        //    int Teacherid = wClient.GetId(requestTeacherModelApi);
        //    RequestModelApi requestTutorModelApi = DataMock.requestTutorModelChuya;
        //    int Tyutorid = wClient.GetId(requestTutorModelApi);
        //    RequestModelApi requestMethodistModelApi = DataMock.requestMethodistModelDazai;
        //    int MethodistId = wClient.GetId(requestMethodistModelApi);

        //    AuthRequestModelApi authRequestModel = new AuthRequestModelApi()
        //    {
        //        Email = "marina@example.com",
        //        Password = "marina123456"
        //    };
        //    string actualToken = wClient.Auth(authRequestModel);
        //    wClient.SetRole(actualToken, Teacherid, "Teacher");
        //    wClient.SetRole(actualToken, Tyutorid, "Tyutor");
        //    wClient.SetRole(actualToken, MethodistId, "Methodist");

        //    CreateGroupeModelApi createGroupeModelApi = new CreateGroupeModelApi()
        //    {
        //        name = "string",
        //        courseId = 1370,
        //        groupStatusId = "Forming",
        //        startDate = "22.12.2022",
        //        endDate = "30.12.2022",
        //        timetable = "stringstring",
        //        paymentPerMonth = 10000,
        //        paymentsCount = 5
        //    };
        //    int idGroup = wClient.GetIdCreatedGroup(actualToken, createGroupeModelApi);

        //    AuthRequestModelApi teacherRequestModel = new AuthRequestModelApi()
        //    {
        //        Email = "willywonka@gmail.com",
        //        Password = "123456789"
        //    };
        //    TaskRequestModelApi taskRequestModelApi = new TaskRequestModelApi()
        //    {
        //        name = "Команда Б",
        //        description = "string",
        //        links = "string",
        //        isRequired = true,
        //        groupId = idGroup
        //    };
        //    string actualTokenTeacher = wClient.Auth(teacherRequestModel);
        //    int idTask = wClient.GetIdTask(actualTokenTeacher, taskRequestModelApi);
        //    int idHomework = wClient.GetCreateHomework(actualTokenTeacher, idGroup, idTask);

        //    wClient.AddUsers(actualToken, idGroup, Studentid, 6);
        //    wClient.AddUsers(actualToken, idGroup, Teacherid, 4);
        //    wClient.AddUsers(actualToken, idGroup, MethodistId, 3);
        //    wClient.AddUsers(actualToken, idGroup, Tyutorid, 5);
        //}
        //[Given(@"Registration as student")]
        //public void GivenRegistrationAsStudent(Table table)
        //{

        //}

        //[Given(@"Auth as admin api")]
        //public void GivenAuthAsAdminApi(Table table)
        //{
        //    throw new PendingStepException();
        //}

        //[Given(@"Give teacher role as admin")]
        //public void GivenGiveTeacherRoleAsAdmin()
        //{
        //    throw new PendingStepException();
        //}

        //[Given(@"Give tutor role as admin")]
        //public void GivenGiveTutorRoleAsAdmin()
        //{
        //    throw new PendingStepException();
        //}

        //[Given(@"Create group as admin")]
        //public void GivenCreateGroupAsAdmin()
        //{
        //    throw new PendingStepException();
        //}

        //[Given(@"Add users in group as admin")]
        //public void GivenAddUsersInGroupAsAdmin()
        //{
        //    throw new PendingStepException();
        //}

        //[Given(@"Auth as teacher api")]
        //public void GivenAuthAsTeacherApi()
        //{
        //    throw new PendingStepException();
        //}

        //[Given(@"Create task")]
        //public void GivenCreateTask()
        //{
        //    throw new PendingStepException();
        //}

        //[Given(@"Create homework")]
        //public void GivenCreateHomework()
        //{
        //    throw new PendingStepException();
        //}

        [Given(@"Registration as student(.*) api")]
        public void GivenRegistrationAsStudentApi(int p0)
        {
            RequestModelApi requestStudentModel1 = DataMock.requestStudentModel1;
            IdStorage.CreateInstance().studentId = _webClient.GetUserId(requestStudentModel1);
            _idStudent = IdStorage.CreateInstance().studentId;

            RequestModelApi requestStudentModel2 = DataMock.requestStudentModel2;
            IdStorage.CreateInstance().teacherId = _webClient.GetUserId(requestStudentModel2);
            _idTeacher = IdStorage.CreateInstance().teacherId;

            RequestModelApi requestStudentModel3 = DataMock.requestStudentModel3;
            IdStorage.CreateInstance().tutorId = _webClient.GetUserId(requestStudentModel3);
            _idTutor = IdStorage.CreateInstance().tutorId;

            RequestModelApi requestStudentModel4 = DataMock.requestStudentModel4;
            IdStorage.CreateInstance().methodistId = _webClient.GetUserId(requestStudentModel4);
            _idMethodist = IdStorage.CreateInstance().methodistId;
        }

        [Given(@"Auth as admin api")]
        public void GivenAuthAsAdminApi(Table table)
        {
            AuthRequestModelApi authAsAdmin = new AuthRequestModelApi()
            {
                Email = "marina@example.com",
                Password = "marina123456"
            };
            IdStorage.CreateInstance().adminToken = _webClient.Auth(authAsAdmin);
            _adminToken = IdStorage.CreateInstance().adminToken;
        }

        [Given(@"Give student(.*) teacher role as admin")]
        public void GivenGiveStudentTeacherRoleAsAdmin(int p0)
        {
            _webClient.SetRole(_adminToken, _idTeacher, "Teacher");
        }

        [Given(@"Give student(.*) tutor role as admin")]
        public void GivenGiveStudentTutorRoleAsAdmin(int p0)
        {
            _webClient.SetRole(_adminToken, _idTutor, "Tutor");
        }

        [Given(@"Give student(.*) methodist role as admin")]
        public void GivenGiveStudentMethodistRoleAsAdmin(int p0)
        {
            _webClient.SetRole(_adminToken,_idMethodist, "Methodist");
        }

        [Given(@"Create courses by admin")]
        public void GivenCreateCoursesByAdmin()
        {
            CreateCourseModelApi createBaseCourse = DataMock.createBaseCourse;
            IdStorage.CreateInstance().courseIdBaseCourse = _webClient.GetIdCreatedCourse(IdStorage.CreateInstance().adminToken, createBaseCourse);
            _idCourseBase = IdStorage.CreateInstance().courseIdBaseCourse;

            CreateCourseModelApi createFrontedCourse = DataMock.createFrontedCourse;
            IdStorage.CreateInstance().courseIdFrontend = _webClient.GetIdCreatedCourse(IdStorage.CreateInstance().adminToken, createFrontedCourse);
            _idCourseFronted = IdStorage.CreateInstance().courseIdFrontend;

            CreateCourseModelApi createBackendCourse = DataMock.createBackendCourse;
            IdStorage.CreateInstance().courseIdBackend = _webClient.GetIdCreatedCourse(IdStorage.CreateInstance().adminToken, createBackendCourse);
            _idCourseBackend = IdStorage.CreateInstance().courseIdBackend;

            CreateCourseModelApi createQAACourse = DataMock.createQAACourse;
            IdStorage.CreateInstance().courseIdQAA = _webClient.GetIdCreatedCourse(IdStorage.CreateInstance().adminToken, createQAACourse);
            _idCourseQAA = IdStorage.CreateInstance().courseIdQAA;
        }

        [Given(@"Create group by admin")]
        public void GivenCreateGroupByAdmin()
        {
            CreateGroupeModelApi createGroupe = DataMock.createGroupe;
            createGroupe.courseId = _idCourseFronted;
            IdStorage.CreateInstance().groupId = _webClient.GetIdCreatedGroup(_adminToken, createGroupe);
            _idGroup = IdStorage.CreateInstance().groupId;
        }

        [Given(@"Add users in group as admin")]
        public void GivenAddUsersInGroupAsAdmin()
        {
            _webClient.AddUsers(_adminToken, _idGroup, _idStudent, 6);
            _webClient.AddUsers(_adminToken,_idGroup, _idTeacher, 4);
            _webClient.AddUsers(_adminToken, _idGroup, _idTutor, 5);
            _webClient.AddUsers(_adminToken, _idGroup, _idMethodist, 3);
        }

        [Given(@"Auth as teacher api")]
        public void GivenAuthAsTeacherApi()
        {
            AuthRequestModelApi authAsTeacher = new AuthRequestModelApi()
            {
                Email = "willywonka10@gmail.com",
                Password = "123456789"
            };
            IdStorage.CreateInstance().teacherToken = _webClient.Auth(authAsTeacher);
            _teacherToken = IdStorage.CreateInstance().teacherToken;
        }

        [Given(@"Create task by teacher")]
        public void GivenCreateTaskByTeacher()
        {
            TaskRequestModelApi taskRequestModelApi1 = DataMock.createTask1;
            taskRequestModelApi1.groupId = _idGroup;
            IdStorage.CreateInstance().taskId = _webClient.GetIdTask(_teacherToken,taskRequestModelApi1);
            _idTask = IdStorage.CreateInstance().taskId;
        }

        [Given(@"Create homework by teacher")]
        public void GivenCreateHomeworkByTeacher()
        {
            HomeworkRequestModelApi homeworkRequestModelApi1 = DataMock.createHomework1;
            _webClient.GetCreateHomework(_teacherToken, _idGroup, _idTask, homeworkRequestModelApi1);
        }

        [When(@"I should see the status of the completed task as ""([^""]*)""")]
        public void WhenIShouldSeeTheStatusOfTheCompletedTaskAs(string проверить)
        {
            throw new PendingStepException();
        }


        [Given(@"Log in as student")]
        public void GivenLogInAsStudent()
        {
            _authPage.EnterEmail("rodionraskol5@gmail.com");
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
