using OpenQA.Selenium.Interactions;
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
        public IWebElement TaskAssignmentDate => _driver.FindElement(By.XPath(@"//input[@value='18.12.2022']"));
        public IWebElement TaskDueDate => _driver.FindElement(By.XPath(@"//div[@class='date-picker form-input ']/following::input[1]"));
        public IWebElement FieldEnterDescriptionTask => _driver.FindElement(By.XPath(@"//textarea[@placeholder='Введите текст']"));
        public IWebElement FieldUsefulLinks => _driver.FindElement(By.XPath(@"//textarea[@class='form-input_link form-input']"));
        public IWebElement ButtonPublish => _driver.FindElement(By.XPath(@"//button[@class='sc-bczRLJ iJvUkY btn btn-fill flex-container']"));
        public IWebElement ButtonSelectRole => _driver.FindElement(By.XPath(@"//div[@class='drop-down-filter  left']"));
        public IWebElement ButtonSelectRoleinList => _driver.FindElement(By.XPath(@"//li[text()='Преподаватель']"));

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
            action.DoubleClick(FieldEnterTitle).Build().Perform();
            FieldEnterTitle.SendKeys(Keys.Backspace);
            FieldEnterTitle.SendKeys(text);
        }
        public void EnterTaskDueDate(string text)
        {
            Actions action = new Actions(_driver);
            action.DoubleClick(FieldEnterDescriptionTask).Build().Perform();
            FieldEnterDescriptionTask.SendKeys(Keys.Backspace);
            FieldEnterDescriptionTask.SendKeys(text);
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
    }
}
