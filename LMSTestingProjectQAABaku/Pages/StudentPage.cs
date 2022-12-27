
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace LMSTestingProjectQAABaku.Pages
{
    public class StudentPage : AbstractPage
    {
        public IWebElement ButtonHomeworkStudent => _driver.FindElement(By.XPath(@"//span[text()='Домашние задания']"));
        public IWebElement ButtonGoToHomeworkPage => _driver.FindElement(By.XPath(@"/html/body/div/div/main/div[1]/div[2]/div/a"));   
        public IWebElement FieldEnterHomeworkLink => _driver.FindElement(By.XPath(@"//input[@placeholder='Ссылка на GitHub или архив']"));
        public IWebElement ButtonHomeworkLinkSend => _driver.FindElement(By.XPath(@"//button[@class='button-fly']"));
        public IWebElement LinkReadyHomework => _driver.FindElement(By.XPath(@"//a[text()='Выполненное задание']"));
        public IWebElement HomeworkStatusName
        {
            get
            {
                WebDriverWait driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
                return driverWait.Until(ExpectedConditions.ElementExists(By.XPath(@"/html/body/div/div/main/div[1]/div[2]/span[2]")));
            }
        }

        public override void Open()
        { 
        }

        public void ClickButtonHomeworkStudent()
        {
            ButtonHomeworkStudent.Click();
        }

        public void ClickButtonGoToHomeworkPage()
        {
            ButtonGoToHomeworkPage.Click();
        }

        public void FillFieldEnterHomeworkLink(string text)
        {
            FieldEnterHomeworkLink.SendKeys(text);
        }

        public void ClickButtonHomeworkLinkSend()
        {
            ButtonHomeworkLinkSend.Click();
        }

        public void ClickLinkReadyHomework()
        {
            LinkReadyHomework.Click();
        }
        
        public string GetHomeworkStatus()
        {
           return HomeworkStatusName.Text;
        }
        
    }
}
