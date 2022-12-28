namespace LMSTestingProjectQAABaku.Drivers
{
    public class DriverStorage
    {
       public WebDriver Driver { get; set; }

        private static DriverStorage _driverStorage;
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

        internal static DriverStorage GetInstance()
        {
            throw new NotImplementedException();
        }
    }
}
