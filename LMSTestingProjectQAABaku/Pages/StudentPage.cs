
namespace LMSTestingProjectQAABaku.Pages
{
    public class StudentPage : AbstractPage
    {
        //Page before send Github link
        public IWebElement ButtonHomeworkStudent => _driver.FindElement(By.XPath(@"//a[@href='/homeworks']"));
        public IWebElement ButtonGoToHomeworkPage => _driver.FindElement(By.XPath(@"/html/body/div/div/main/div[1]/div[2]/div/a"));   
        public IWebElement FieldEnterHomeworkLink => _driver.FindElement(By.XPath(@"//input[@placeholder='Ссылка на GitHub или архив']"));
        public IWebElement ButtonHomeworkLinkSend => _driver.FindElement(By.XPath(@"//button[@class='button-fly']"));

        //Page before send Github link
        public IWebElement LinkReadyHomework => _driver.FindElement(By.XPath(@"//a[text()='Выполненное задание']"));

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

    }
}
