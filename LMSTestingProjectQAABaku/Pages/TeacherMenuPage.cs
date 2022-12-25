using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSTestingProjectQAABaku.Pages
{
    public class TeacherMenuPage : AbstractPage
    {
        public override void Open()
        {
        }
        public IWebElement ButtonUserNameMenu => _driver.FindElement(By.XPath(@"//div[@class='drop-down-filter__wrapper']"));
        public IWebElement ButtonSelectTeacher => _driver.FindElement(By.XPath(@"//li[text()='Преподаватель'][1]"));
        public IWebElement ButtonAvatarName => _driver.FindElement(By.XPath(@"//span[@class='avatar-name transition-styles']"));
        public IWebElement ButtonAvatarRole => _driver.FindElement(By.XPath(@"//div[@class='drop-down-filter  left']"));
        public IWebElement ButtonHomework => _driver.FindElement(By.XPath(@"//span[text()='Домашние задания']"));
        public IWebElement ButtonAddTask => _driver.FindElement(By.XPath(@"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']"));
        public IWebElement ButtonSelectGroup => _driver.FindElement(By.XPath(@"//span[@class='radio-text']"));
        public IWebElement FieldEnterTitle => _driver.FindElement(By.XPath(@"//input[@placeholder='Введите название']"));
        public IWebElement TaskAssignmentDate => _driver.FindElement(By.XPath(@"//div[text()='Дата выдачи задания']/child::div/child::div/child::div/child::input"));
        public IWebElement TaskDueDate => _driver.FindElement(By.XPath(@"//div[text()='Срок сдачи задания']/child::div/child::div/child::div/child::input"));
        public IWebElement FieldEnterDescriptionTask => _driver.FindElement(By.XPath(@"//textarea[@placeholder='Введите текст']"));
        public IWebElement FieldUsefulLinks => _driver.FindElement(By.XPath(@"//textarea[@class='form-input_link form-input']"));
        public IWebElement ButtonPublish => _driver.FindElement(By.XPath(@"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']"));
        public IWebElement ButtonSelectRole => _driver.FindElement(By.XPath(@"//div[@class='drop-down-filter  left']"));
        public IWebElement ButtonSelectRoleinList => _driver.FindElement(By.XPath(@"//li[text()='Преподаватель']"));
        public IWebElement ButtonAddHomework => _driver.FindElement(By.XPath(@"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']"));
        public IWebElement ButtonPinLink => _driver.FindElement(By.XPath(@"//button[@class='sc-bczRLJ kEeNDb btn btn-fill ellipse flex-container']"));
        public IWebElement TextBoxHomeworkName
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='Проектики'")));
            }
        }

        public void GetClickButtonUserNameMenu()
        {
            ButtonUserNameMenu.Click();
        }
        public void GetClickButtonSelectTeacher()
        {
            ButtonSelectTeacher.Click();
        }
        public string GetTextButtonAvatarRole()
        {
            return ButtonAvatarRole.Text;
        }
        public string GetTextButtonAvatarName()
        {
            return ButtonAvatarName.Text;
        }
        public void GetClickButtonHomework()
        {
            ButtonHomework.Click();
        }
        public void GetClickButtonAddTask()
        {
            ButtonAddTask.Click();
        }
        public void GetClickButtonSelectGroup()
        {
            ButtonSelectGroup.Click();
        }
        public void GetClickButtonButtonAddTask()
        {
            ButtonAddTask.Click();
        }
        public void EnterTaskTitle(string text)
        {
            FieldEnterTitle.SendKeys(text);
        }
        public void EnterFieldDescriptionTask(string text)
        {
            FieldEnterDescriptionTask.SendKeys(text);
        }
        public void EnterTaskAssignmentDate(string text)
        {
            Actions action = new Actions(_driver);
            action.DoubleClick(TaskAssignmentDate).Build().Perform();
            TaskAssignmentDate.SendKeys(Keys.Backspace);
            TaskAssignmentDate.SendKeys(text);
        }
        public void EnterTaskDueDate(string text)
        {
            Actions action = new Actions(_driver);
            action.DoubleClick(TaskDueDate).Build().Perform();
            TaskDueDate.SendKeys(Keys.Backspace);
            TaskDueDate.SendKeys(text);
        }
        public void EnterFieldUsefulLinks(string text)
        {
            FieldUsefulLinks.SendKeys(text);
        }
        public void ClickButtonPublish()
        {
            ButtonPublish.Click();
        }
        public void SelectTeacherRole()
        {
            ButtonSelectRole.Click();
            ButtonSelectRoleinList.Click();
        }

        public void ClickButtonAddHomework()
        {
            ButtonAddHomework.Click();
        }
        public void ClickButtonPinLink()
        {
            ButtonPinLink.Click();
        }

        public string GetHomeworkName()
        {
           return TextBoxHomeworkName.Text;
        }

    }
}
