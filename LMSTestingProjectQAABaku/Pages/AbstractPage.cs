using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMSTestingProjectQAABaku.Drivers;
 

namespace LMSTestingProjectQAABaku.Pages
{
    public abstract class AbstractPage
    {
        protected WebDriver _driver;

        public AbstractPage()
        { 
          _driver = DriverStorage.Get().Driver;
        }

        public void Refresh()
        { 
          _driver.Navigate().Refresh();
        }
        public abstract void Open();
    }
}
