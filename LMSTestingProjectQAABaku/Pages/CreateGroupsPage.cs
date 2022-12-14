namespace LMSTestingProjectQAABaku.Pages
{
    public class CreateGroupsPage: AbstractPage
    {
        public IWebElement TextBoxGroupName => _driver.FindElement(By.XPath(@"//input[@placeholder = 'Введите название']"));
        public IWebElement CheckboxForChooseCourses => _driver.FindElement(By.XPath(@"//div[@class='drop-down-filter  ']"));
        public IWebElement ButtonForChooseCourse => _driver.FindElement(By.XPath(@"//li[text()='FrontedCourse']"));
        public IWebElement CheckboxForChooseTeacher => _driver.FindElement(By.XPath(@"/html/body/div/div/main/div[1]/form/div[3]/div/label[16]/span"));
        public IWebElement CheckboxForChooseTutor => _driver.FindElement(By.XPath(@"//span[text()='Чуя Накахара']"));
        public IWebElement ButtonForSave => _driver.FindElement(By.XPath(@"//button[@class = 'sc-bczRLJ iJvUkY btn btn-fill flex-container']"));
        public IWebElement TitleGroup => _driver.FindElement(By.XPath(@"//div[text()='Шумные дети - группа1']"));


        public override void Open()
        {
            _driver.Navigate().GoToUrl("https://piter-education.ru:7074/login");
        }

        public void EnterGroupName(string text)
        {
            TextBoxGroupName.SendKeys(text);
        }

        public void ChooseCourses()
        {
            CheckboxForChooseCourses.Click();
        }

        public void ChooseConcretCourses()
        {
            ButtonForChooseCourse.Click();
        }

        public void ChooseTeacher()
        {
            CheckboxForChooseTeacher.Click();
        }

        public void ChooseTutor()
        {
            CheckboxForChooseTutor.Click();
        }

        public void SaveButton()
        {
            ButtonForSave.Click();
        }

        public string GroupNameTitle()
        {
            return TitleGroup.Text;
        }
    }
}