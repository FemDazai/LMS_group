using LMSTestingProjectQAABaku.Models;
using LMSTestingProjectQAABaku.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace LMSTestingProjectQAABaku.StepDefinitions
{
    [Binding]
    public class HomeworkFunctionsStepDefinitions
    {
        AuthPage _authPage;
        ManagerMenuPage _managerMenuPage;
        TeacherMenuPage _teacherMenuPage;

        public HomeworkFunctionsStepDefinitions()
        {
            _authPage = new AuthPage();
            _managerMenuPage = new ManagerMenuPage();
            _teacherMenuPage = new TeacherMenuPage();
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
    }
}
