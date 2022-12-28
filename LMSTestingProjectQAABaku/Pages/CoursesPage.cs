namespace LMSTestingProjectQAABaku.Pages
{
    public class CoursesPage: AbstractPage
    {
        public IWebElement ButtonTopicsNameTitle => _driver.FindElement(By.XPath(@"//span[text()='Двумерные массивы']"));

        public override void Open()
        {
            _driver.Navigate().GoToUrl("https://piter-education.ru:7074/login");
        }

        public string ButtTopicsName()
        {
             return ButtonTopicsNameTitle.Text;
        }

    }
}
