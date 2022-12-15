using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSTestingProjectQAABaku.Drivers
{
    public class DriverStorage
    {
       public WebDriver Driver { get; set; }

        private static DriverStorage _driverStorage;//переменная для хранения ссылки на объкт класса 
        private DriverStorage()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        public static DriverStorage Get()
        {
            if (_driverStorage == null)
            {
                _driverStorage = new DriverStorage();
            }

            return _driverStorage;
        }
    }
}
