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

    }
}
