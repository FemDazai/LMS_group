using TechTalk.SpecFlow;
using LMSTestingProjectQAABaku.Drivers;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace LMSTestingProjectQAABaku.Support
{
    [Binding]
    public sealed class Hooks1
    {
        [AfterScenario]
        public void AfterScenario()
        {
            DriverStorage.Get().Driver.Close();
        }
    }
    //public class DBCleaner
    //{
    //    [AfterScenario]
    //    public void Clear()
    //    {
    //        string connectionString = @"Data Source=80.78.240.16; Initial Catalog = DevEdu; User Id =student; Password=qwe!23";
    //        IDbConnection dbconnection = new SqlConnection(connectionString);
    //        dbconnection.Open();
    //        dbconnection.Query("вelete from User_Role where UserId <> 5799 and UserId <> 5802");
    //        dbconnection.Close();
    //        //добавление класса по очистике бд
    //    }
    //}
}