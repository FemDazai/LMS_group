namespace LMSTestingProjectQAABaku.Pages
{
    public class AfterGithub : AbstractPage
    {
        public override void Open()
        {
            _driver.Navigate().GoToUrl(@"https://github.com/El-ItsMe/Project-Test-1");
        }
    }
}
