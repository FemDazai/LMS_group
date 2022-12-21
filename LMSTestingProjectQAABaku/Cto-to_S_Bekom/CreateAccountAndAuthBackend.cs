using LMSTestingProjectQAABaku.Models;
using LMSTestingProjectQAABaku.ModelsApi;

namespace LMSTestingProjectQAABaku.Cto_to_S_Bekom
{
    public class CreateAccountAndAuthBackend
    {
        public void BackFunctions()
        {
            //WebClient wClient = new WebClient();
            //RequestModelApi requestStudentModel = new RequestModelApi()
            //{
            //    firstName = "Родион",
            //    lastName = "Раскольников",
            //    patronymic = "Романович",
            //    email = "rodionraskol@gmail.com",
            //    username = "Rodion",
            //    password = "123456789",
            //    city = "SaintPetersburg",
            //    birthDate = "15.12.1999",
            //    gitHubAccount = "github.com/Rodionchik",
            //    phoneNumber = "+72222222221"
            //};
            //int Studentid = wClient.GetId(requestStudentModel);
            //RequestModelApi requestTeacherApiModel = new RequestModelApi()
            //{
            //    firstName = "Вилли",
            //    lastName = "Вонка",
            //    patronymic = "ОтецВиллиВонка",
            //    email = "willywonka@gmail.com",
            //    username = "willy",
            //    password = "123456789",
            //    city = "SaintPetersburg",
            //    birthDate = "15.12.1980",
            //    gitHubAccount = "github.com/JohnnyDepp",
            //    phoneNumber = "+72222222222"
            //};
            //int Teacherid = wClient.GetId(requestTeacherApiModel);

            //RequestModelApi requestTyutorApiModel = new RequestModelApi()
            //{
            //    firstName = "Чуя",
            //    lastName = "Накахара",
            //    patronymic = "Огаев",
            //    email = "chuchu@gmail.com",
            //    username = "jenaDazaya",
            //    password = "123456789",
            //    city = "SaintPetersburg",
            //    birthDate = "25.12.1990",
            //    gitHubAccount = "github.com/ChuChu",
            //    phoneNumber = "+72222222223"
            //};
            //int Tyutorid = wClient.GetId(requestTyutorApiModel);

            //RequestModelApi requestMethodistApiModel = new RequestModelApi()
            //{
            //    firstName = "Дазай",
            //    lastName = "Осаму",
            //    patronymic = "Одавич",
            //    email = "dazai@gmail.com",
            //    username = "chuyamilaxa",
            //    password = "123456789",
            //    city = "SaintPetersburg",
            //    birthDate = "15.12.1980",
            //    gitHubAccount = "github.com/Dazai",
            //    phoneNumber = "+72222222224"
            //};
            //int MethodistId = wClient.GetId(requestMethodistApiModel);

            //AuthRequestModelApi authRequestModel = new AuthRequestModelApi()
            //{
            //    Email = "marina@example.com",
            //    Password = "marina123456"
            //};
            //string actualToken = wClient.Auth(authRequestModel);
            //wClient.SetRole(actualToken, Teacherid, "Teacher");
            //wClient.SetRole(actualToken, Tyutorid, "Tyutor");
            //wClient.SetRole(actualToken, MethodistId, "Methodist");

            //CreateGroupeModelApi createGroupeModelApi = new CreateGroupeModelApi()
            //{
            //    name = "string",
            //    courseId = 1370,
            //    groupStatusId = "Forming",
            //    startDate = "22.12.2022",
            //    endDate = "30.12.2022",
            //    timetable = "stringstring",
            //    paymentPerMonth = 10000,
            //    paymentsCount = 5
            //};
            //int idGroup = wClient.GetIdCreatedGroup(actualToken, createGroupeModelApi);

            //AuthRequestModelApi teacherRequestModel = new AuthRequestModelApi()
            //{
            //    Email = "willywonka@gmail.com",
            //    Password = "123456789"
            //};
            //TaskRequestModelApi taskRequestModelApi = new TaskRequestModelApi()
            //{
            //    name = "Команда Б",
            //    description = "string",
            //    links = "string",
            //    isRequired = true,
            //    groupId = idGroup
            //};
            //string actualTokenTeacher = wClient.Auth(teacherRequestModel);
            //int idTask = wClient.GetIdTask(actualTokenTeacher, taskRequestModelApi);
            //int idHomework = wClient.GetCreateHomework(actualTokenTeacher, idGroup, idTask);

            //wClient.AddUsers(actualToken, idGroup, Studentid, 6);
            //wClient.AddUsers(actualToken, idGroup, Teacherid, 4);
            //wClient.AddUsers(actualToken, idGroup, MethodistId, 3);
            //wClient.AddUsers(actualToken, idGroup, Tyutorid, 5);
        }
    }
}
