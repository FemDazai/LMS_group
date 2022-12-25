using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace LMSTestingProjectQAABaku.Support
{
    [Binding]
    public sealed class Hooks1
    {
        //[AfterScenario]
        //public void AfterScenario()
        //{
        //    DriverStorage.Get().Driver.Close();
        //}


        [BeforeScenario]
        public void BeforeScenario()
        {
            string connectionString = @"Data Source = 80.78.240.16; Initial Catalog = DevEdu; Persist Security Info = True; User ID = student; Password = qwe!23;";
            IDbConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
            dbConnection.Query($"delete from Course_Material");
            dbConnection.Query($"delete from Course_Topic");
            dbConnection.Query($"delete from Material");
            dbConnection.Query($"delete from Course_Task");
            dbConnection.Query($"delete from StudentRating");
            dbConnection.Query($"delete from User_Group");
            dbConnection.Query($"delete from Group_Lesson");
            dbConnection.Query($"delete from Comment");
            dbConnection.Query($"delete from Student_Homework");
            dbConnection.Query($"delete from Homework");
            dbConnection.Query($"delete from Task");
            dbConnection.Query($"delete from [Group]");
            dbConnection.Query($"delete from Course");
            dbConnection.Close();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //DriverStorage.GetInstance().Driver.Close();
            string connectionString = @"Data Source = 80.78.240.16; Initial Catalog = DevEdu; Persist Security Info = True; User ID = student; Password = qwe!23;";
            IDbConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
            /*dbConnection.Query($"delete from Course_Material");
            dbConnection.Query($"delete from Course_Topic");
            dbConnection.Query($"delete from Material");
            dbConnection.Query($"delete from Course_Task");
            dbConnection.Query($"delete from StudentRating");
            dbConnection.Query($"delete from User_Group");
            dbConnection.Query($"delete from Group_Lesson");
            dbConnection.Query($"delete from Comment");
            dbConnection.Query($"delete from Student_Homework");
            dbConnection.Query($"delete from Homework");
            dbConnection.Query($"delete from Task");
            dbConnection.Query($"delete from [Group]");
            dbConnection.Query($"delete from Course");*/

            {
                dbConnection.Query($"delete from Payment where UserId = {_idTeacher}");
                dbConnection.Query($"delete from Student_Lesson where UserId = (select Id from [User] where Email = '{item}');");
                dbConnection.Query($"delete from Group_Lesson where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = '{item}'));");
                dbConnection.Query($"delete from Lesson_Topic where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = '{item}'));");
                dbConnection.Query($"delete from Lesson where TeacherId = (select Id from [User] where Email = '{item}');");
                dbConnection.Query($"delete from User_Group where UserId = (select Id from [User] where Email = '{item}');");
                dbConnection.Query($"delete from StudentRating where UserId = (select Id from [User] where Email = '{item}');");
                dbConnection.Query($"delete from User_Role where UserId = (select Id from [User] where Email = '{item}');");
                dbConnection.Query($"delete from [Notification] where UserId = (select Id from [User] where Email = '{item}');");
                dbConnection.Query($"delete from Comment where UserId = (select Id from [User] where Email = '{item}');");
                dbConnection.Query($"delete from Comment where StudentHomeworkId = (select Id from [Student_Homework] where StudentId = (select Id from [User] where Email = '{item}'));");
                dbConnection.Query($"delete from Student_Homework where StudentId = (select Id from [User] where Email = '{item}');");
                dbConnection.Query($"delete from [User] where Email = '{item}';");
            }
            dbConnection.Close();

        }
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
