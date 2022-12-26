using LMSTestingProjectQAABaku.Models;
using LMSTestingProjectQAABaku.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace LMSTestingProjectQAABaku.StepDefinitions
{
    [Binding]
    public class CreateGroupStepDefinitions
    {
        AuthPage _authPage;
        CreateGroupsPage _createGroupsPage;
        ManagerMenuPage _managerMenuPage;
        GroupsPage _groupsPage; 
        EditCoursesPage _editCoursesPage;
        MethodistMenuPage _methodistMenuPage;
        CoursesPage _coursesPage;

        public CreateGroupStepDefinitions()
        {
            _authPage = new AuthPage();
            _createGroupsPage = new CreateGroupsPage();
            _managerMenuPage = new ManagerMenuPage();
            _editCoursesPage = new EditCoursesPage();   
            _methodistMenuPage = new MethodistMenuPage();  
            _coursesPage = new CoursesPage();
        }

        [Given(@"Log in as manager")]
        public void GivenLogInAsManager()
        {
            _authPage.Open();
            _authPage.EnterEmail("marina@example.com");
            _authPage.EnterPassword("marina123456");
            _authPage.ClickAuthButton();
        }

        [Given(@"Go to the tab ""([^""]*)""")]

        public void GivenGoToTheTab(string p0)
        {
            _managerMenuPage.ClickCreateGroupButton();
        }

        [When(@"Click to  the button admin")]
        public void WhenClickToTheButtonAdmin()
        {
            _managerMenuPage.GetClickButtonSelectAdmin();
        }

        [When(@"I fill in all the fields in page and choose teacher and tyutor")]
        public void WhenIFillInAllTheFieldsInPageAndChooseTeacherAndTyutor(Table table)
        {
            var createTable = table.CreateInstance<CreateGroupsModel>();

            _createGroupsPage.EnterGroupName(createTable.GroupName);
            _createGroupsPage.ChooseTeacher();
            _createGroupsPage.ChooseTutor();
        }

        [When(@"Click on  ""([^""]*)"" button")]
        public void WhenClickOnButton(string save)
        {
           _createGroupsPage.SaveButton();//не нажимает на кнопку бяка фу
        }

        [When(@"Click on ""([^""]*)""")]
        public void WhenClickOn(string группы)
        {
            _managerMenuPage.ClickGroupButton();
        }

        [Then(@"The created group will appear in the list of groups")]
        public void ThenTheCreatedGroupWillAppearInTheListOfGroups()
        {
            _groupsPage.ButtonGroupName();

            string exception = "Шумные дети - группа1";
            string actual= _createGroupsPage.GroupNameTitle();
            Assert.Equal(exception, actual);

        }

        [Given(@"Auth as methodist")]
        public void GivenAuthAsMethodist(Table table)
        {
            var addTable = table.CreateInstance<AuthModel>();
            _authPage.EnterEmail(addTable.Email);
            _authPage.EnterPassword(addTable.Password);
        }

        [When(@"Click to  the button methodist")]
        public void WhenClickToTheButtonMethodist()
        {
            _methodistMenuPage.ClickButtonSelectMethodist();
        }


        [When(@"Click ""([^""]*)"" button")]
        public void WhenClickButton(string p0)
        {
            _methodistMenuPage.ClickButtonEditCourses();    
        }

        [When(@"Creating a new topic")]
        public void WhenCreatingANewTopic()
        {
            _editCoursesPage.EnterNumber("7");
            _editCoursesPage.EnterTopicName("Двумерные массивы");
            _editCoursesPage.EnterDuration("2");
        }

        [When(@"Click  ""([^""]*)""  button")]
        public void WhenClickSaveButton(string сохранить)
        {
            _editCoursesPage.ClickSaveButton();
        }

        [Then(@"Click ""([^""]*)"" button")]
        public void ThenClickButton(string курсы)
        {
            _methodistMenuPage.ClickButtonCourses();    
        }

        [Then(@"I shold to see the new topic in list")]
        public void ThenISholdToSeeTheNewTopicInList()
        {
            string expected = "Двумерные массивы";
            string actual = _coursesPage.ButtTopicsName();
            Assert.Equal(expected, actual);
        }

    }
}
