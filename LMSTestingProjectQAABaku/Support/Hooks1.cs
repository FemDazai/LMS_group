using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using Dapper;
using LMSTestingProjectQAABaku.StepDefinitions;

namespace LMSTestingProjectQAABaku.Support
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {

            //List<string> emails = new List<string>();
            //emails.Add(CreateTeacherStepDefinitions.Email);
            //emails.Add(WatchHomeWorksAsStudentStepDefinitions.Email);
            //emails.Add(ViewListOfStudentsAsManagerStepDefinitions.Email);
            //emails.Add(AddNewGroupStepDefinitions.Email1);
            //emails.Add(AddNewGroupStepDefinitions.Email2);
            //emails.Add(EditCoursesAsMethodologistStepDefinitions.Email);
            //emails.AddRange(CreateHomeworkStepDefinitions.Emails);

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
         
            string connectionString = @"Data Source = 80.78.240.16; Initial Catalog = DevEdu; Persist Security Info = True; User ID = student; Password = qwe!23;";
            IDbConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
            
            dbConnection.Query($"delete from Payment where UserId = (select Id from [User] where Email = 'rodionraskol30@gmail.com');");
            dbConnection.Query($"delete from Student_Lesson where UserId = (select Id from [User] where Email = 'rodionraskol30@gmail.com');");
            dbConnection.Query($"delete from Group_Lesson where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = 'rodionraskol30@gmail.com'));");
            dbConnection.Query($"delete from Lesson_Topic where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = 'rodionraskol30@gmail.com'));");
            dbConnection.Query($"delete from Lesson where TeacherId = (select Id from [User] where Email = 'rodionraskol30@gmail.com');");
            dbConnection.Query($"delete from User_Group where UserId = (select Id from [User] where Email = 'rodionraskol30@gmail.com');");
            dbConnection.Query($"delete from StudentRating where UserId = (select Id from [User] where Email = 'rodionraskol30@gmail.com');");
            dbConnection.Query($"delete from User_Role where UserId = (select Id from [User] where Email = 'rodionraskol30@gmail.com');");
            dbConnection.Query($"delete from [Notification] where UserId = (select Id from [User] where Email = 'rodionraskol30@gmail.com');");
            dbConnection.Query($"delete from Comment where UserId = (select Id from [User] where Email = 'rodionraskol30@gmail.com');");
            dbConnection.Query($"delete from Comment where StudentHomeworkId = (select Id from [Student_Homework] where StudentId = (select Id from [User] where Email = 'rodionraskol30@gmail.com'));");
            dbConnection.Query($"delete from Student_Homework where StudentId = (select Id from [User] where Email = 'rodionraskol30@gmail.com');");
            dbConnection.Query($"delete from [User] where Email = 'rodionraskol30@gmail.com';");

            dbConnection.Query($"delete from Payment where UserId = (select Id from [User] where Email = 'willywonka30@gmail.com');");
            dbConnection.Query($"delete from Student_Lesson where UserId = (select Id from [User] where Email = 'willywonka30@gmail.com');");
            dbConnection.Query($"delete from Group_Lesson where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = 'willywonka30@gmail.com'));");
            dbConnection.Query($"delete from Lesson_Topic where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = 'willywonka30@gmail.com'));");
            dbConnection.Query($"delete from Lesson where TeacherId = (select Id from [User] where Email = 'willywonka30@gmail.com');");
            dbConnection.Query($"delete from User_Group where UserId = (select Id from [User] where Email = 'willywonka30@gmail.com');");
            dbConnection.Query($"delete from StudentRating where UserId = (select Id from [User] where Email = 'willywonka30@gmail.com');");
            dbConnection.Query($"delete from User_Role where UserId = (select Id from [User] where Email = 'willywonka30@gmail.com');");
            dbConnection.Query($"delete from [Notification] where UserId = (select Id from [User] where Email = 'willywonka30@gmail.com');");
            dbConnection.Query($"delete from Comment where UserId = (select Id from [User] where Email = 'willywonka30@gmail.com');");
            dbConnection.Query($"delete from Comment where StudentHomeworkId = (select Id from [Student_Homework] where StudentId = (select Id from [User] where Email = 'willywonka30@gmail.com'));");
            dbConnection.Query($"delete from Student_Homework where StudentId = (select Id from [User] where Email = 'willywonka30@gmail.com');");
            dbConnection.Query($"delete from [User] where Email = 'willywonka30@gmail.com';");

            dbConnection.Query($"delete from Payment where UserId = (select Id from [User] where Email = 'chuchu30@gmail.com');");
            dbConnection.Query($"delete from Student_Lesson where UserId = (select Id from [User] where Email = 'chuchu30@gmail.com');");
            dbConnection.Query($"delete from Group_Lesson where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = 'chuchu30@gmail.com'));");
            dbConnection.Query($"delete from Lesson_Topic where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = 'chuchu30@gmail.com'));");
            dbConnection.Query($"delete from Lesson where TeacherId = (select Id from [User] where Email = 'chuchu30@gmail.com');");
            dbConnection.Query($"delete from User_Group where UserId = (select Id from [User] where Email = 'chuchu30@gmail.com');");
            dbConnection.Query($"delete from StudentRating where UserId = (select Id from [User] where Email = 'chuchu30@gmail.com');");
            dbConnection.Query($"delete from User_Role where UserId = (select Id from [User] where Email = 'chuchu30@gmail.com');");
            dbConnection.Query($"delete from [Notification] where UserId = (select Id from [User] where Email = 'chuchu30@gmail.com');");
            dbConnection.Query($"delete from Comment where UserId = (select Id from [User] where Email = 'chuchu30@gmail.com');");
            dbConnection.Query($"delete from Comment where StudentHomeworkId = (select Id from [Student_Homework] where StudentId = (select Id from [User] where Email = 'chuchu30@gmail.com'));");
            dbConnection.Query($"delete from Student_Homework where StudentId = (select Id from [User] where Email = 'chuchu30@gmail.com');");
            dbConnection.Query($"delete from [User] where Email = 'chuchu30@gmail.com';");

            dbConnection.Query($"delete from Payment where UserId = (select Id from [User] where Email = 'dazai30@gmail.com');");
            dbConnection.Query($"delete from Student_Lesson where UserId = (select Id from [User] where Email = 'dazai30@gmail.com');");
            dbConnection.Query($"delete from Group_Lesson where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = 'dazai30@gmail.com'));");
            dbConnection.Query($"delete from Lesson_Topic where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = 'dazai30@gmail.com'));");
            dbConnection.Query($"delete from Lesson where TeacherId = (select Id from [User] where Email = 'dazai30@gmail.com');");
            dbConnection.Query($"delete from User_Group where UserId = (select Id from [User] where Email = 'dazai30@gmail.com');");
            dbConnection.Query($"delete from StudentRating where UserId = (select Id from [User] where Email = 'dazai30@gmail.com');");
            dbConnection.Query($"delete from User_Role where UserId = (select Id from [User] where Email = 'dazai30@gmail.com');");
            dbConnection.Query($"delete from [Notification] where UserId = (select Id from [User] where Email = 'dazai30@gmail.com');");
            dbConnection.Query($"delete from Comment where UserId = (select Id from [User] where Email = 'dazai30@gmail.com');");
            dbConnection.Query($"delete from Comment where StudentHomeworkId = (select Id from [Student_Homework] where StudentId = (select Id from [User] where Email = 'dazai30@gmail.com'));");
            dbConnection.Query($"delete from Student_Homework where StudentId = (select Id from [User] where Email = 'dazai30@gmail.com');");
            dbConnection.Query($"delete from [User] where Email = 'dazai30@gmail.com';");

            dbConnection.Query($"delete from Payment where UserId = (select Id from [User] where Email = 'perojoknebulka24@gmail.com');");
            dbConnection.Query($"delete from Student_Lesson where UserId = (select Id from [User] where Email = 'perojoknebulka24@gmail.com ');");
            dbConnection.Query($"delete from Group_Lesson where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = 'perojoknebulka24@gmail.com'));");
            dbConnection.Query($"delete from Lesson_Topic where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = 'perojoknebulka24@gmail.com'));");
            dbConnection.Query($"delete from Lesson where TeacherId = (select Id from [User] where Email = 'perojoknebulka24@gmail.com');");
            dbConnection.Query($"delete from User_Group where UserId = (select Id from [User] where Email = 'perojoknebulka24@gmail.com');");
            dbConnection.Query($"delete from StudentRating where UserId = (select Id from [User] where Email = 'perojoknebulka24@gmail.com');");
            dbConnection.Query($"delete from User_Role where UserId = (select Id from [User] where Email = 'perojoknebulka24@gmail.com');");
            dbConnection.Query($"delete from [Notification] where UserId = (select Id from [User] where Email = 'perojoknebulka24@gmail.com');");
            dbConnection.Query($"delete from Comment where UserId = (select Id from [User] where Email = 'perojoknebulka24@gmail.com');");
            dbConnection.Query($"delete from Comment where StudentHomeworkId = (select Id from [Student_Homework] where StudentId = (select Id from [User] where Email = 'perojoknebulka24@gmail.com'));");
            dbConnection.Query($"delete from Student_Homework where StudentId = (select Id from [User] where Email = 'perojoknebulka24@gmail.com');");
            dbConnection.Query($"delete from [User] where Email = 'perojoknebulka24@gmail.com';");

            dbConnection.Query($"delete from Payment where UserId = (select Id from [User] where Email = 'grigoriyRasputin@gmail.com');");
            dbConnection.Query($"delete from Student_Lesson where UserId = (select Id from [User] where Email = 'grigoriyRasputin@gmail.com');");
            dbConnection.Query($"delete from Group_Lesson where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = 'grigoriyRasputin@gmail.com'));");
            dbConnection.Query($"delete from Lesson_Topic where LessonId = (select Id from [Lesson] where TeacherId = (select Id from [User] where Email = 'grigoriyRasputin@gmail.com'));");
            dbConnection.Query($"delete from Lesson where TeacherId = (select Id from [User] where Email = 'grigoriyRasputin@gmail.com');");
            dbConnection.Query($"delete from User_Group where UserId = (select Id from [User] where Email = 'grigoriyRasputin@gmail.com');");
            dbConnection.Query($"delete from StudentRating where UserId = (select Id from [User] where Email = 'grigoriyRasputin@gmail.com');");
            dbConnection.Query($"delete from User_Role where UserId = (select Id from [User] where Email = 'grigoriyRasputin@gmail.com');");
            dbConnection.Query($"delete from [Notification] where UserId = (select Id from [User] where Email = 'grigoriyRasputin@gmail.com');");
            dbConnection.Query($"delete from Comment where UserId = (select Id from [User] where Email = 'grigoriyRasputin@gmail.com');");
            dbConnection.Query($"delete from Comment where StudentHomeworkId = (select Id from [Student_Homework] where StudentId = (select Id from [User] where Email = 'grigoriyRasputin@gmail.com'));");
            dbConnection.Query($"delete from Student_Homework where StudentId = (select Id from [User] where Email = 'grigoriyRasputin@gmail.com');");
            dbConnection.Query($"delete from [User] where Email = 'grigoriyRasputin@gmail.com';");
            dbConnection.Close();
        }
    }
}