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

        public CreateGroupStepDefinitions()
        {
            _authPage = new AuthPage();
            _createGroupsPage = new CreateGroupsPage();
            _managerMenuPage = new ManagerMenuPage();
        }

        [Given(@"Log in as manager")]
        public void GivenLogInAsManager()
        {
            _authPage.Open();

            _authPage.EnterEmail("marina@example.com");
            _authPage.EnterPassword("marina123456");
            _authPage.ClickAuthButton();

            Thread.Sleep(500);
        }

        [Given(@"Go to the tab ""([^""]*)""")]

        public void GivenGoToTheTab(string p0)
        {
            _managerMenuPage.ClickCreateGroupButton();
            Thread.Sleep(1000);
        }

        [When(@"I fill in all the fields in page and choose teacher and tyutor")]
        public void WhenIFillInAllTheFieldsInPageAndChooseTeacherAndTyutor(Table table)
        {
            var createTable = table.CreateInstance<CreateGroupsModel>();

            _createGroupsPage.EnterGroupName(createTable.GroupName);
            _createGroupsPage.ChooseCourses();
            _createGroupsPage.ChooseConcretCourses();
            _createGroupsPage.ChooseTeacher();
            _createGroupsPage.ChooseTutor();
        }

        [When(@"Click on  ""([^""]*)"" button")]
        public void WhenClickOnButton(string save)
        {
           _createGroupsPage.SaveButton();//не нажимает на кнопку бяка фу
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
    }
}
