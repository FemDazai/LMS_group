using LMSTestingProjectQAABaku.Models;
using LMSTestingProjectQAABaku.ModelsApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSTestingProjectQAABaku
{
    public class DataMock
    {
        public static RequestModelApi requestStudentModel1
        { 
            get 
            { 
                return new RequestModelApi()
                {
                    firstName = "Родион",
                    lastName = "Раскольников",
                    patronymic = "Романович",
                    email = "rodionraskol10@gmail.com",
                    username = "Rodion",
                    password = "123456789",
                    city = "SaintPetersburg",
                    birthDate = "15.12.1999",
                    gitHubAccount = "github.com/Rodionchik",
                    phoneNumber = "+72222222221"
                };
            } 
        }
        public static RequestModelApi requestStudentModel2
        {
            get
            { 
                return new RequestModelApi()
                {
                    firstName = "Вилли",
                    lastName = "Вонка",
                    patronymic = "ОтецВиллиВонка",
                    email = "willywonka10@gmail.com",
                    username = "willy",
                    password = "123456789",
                    city = "SaintPetersburg",
                    birthDate = "15.12.1980",
                    gitHubAccount = "github.com/JohnnyDepp",
                    phoneNumber = "+72222222222"
                };
            }
        }

        public static RequestModelApi requestStudentModel3
        {
            get
            {
                return new RequestModelApi()
                {
                    firstName = "Чуя",
                    lastName = "Накахара",
                    patronymic = "Огаев",
                    email = "chuchu8@gmail.com",
                    username = "jenaDazaya",
                    password = "123456789",
                    city = "SaintPetersburg",
                    birthDate = "25.12.1990",
                    gitHubAccount = "github.com/ChuChu",
                    phoneNumber = "+72222222223"
                };
            }
        }

        public static RequestModelApi requestStudentModel4
        {
            get
            {
                return new RequestModelApi()
                {
                    firstName = "Дазай",
                    lastName = "Осаму",
                    patronymic = "Одавич",
                    email = "dazai8@gmail.com",
                    username = "chuyamilaxa",
                    password = "123456789",
                    city = "SaintPetersburg",
                    birthDate = "15.12.1980",
                    gitHubAccount = "github.com/Dazai",
                    phoneNumber = "+72222222224"
                };
            }
        }

        public static CreateCourseModelApi createBaseCourse
        {
            get
            {
                return new CreateCourseModelApi()
                { 
                    name = "BaseCourse-C#",
                    description = "BaseCourse-C#"
                };
            }
        }
        
        public static CreateCourseModelApi createFrontedCourse
        {
            get
            {
                return new CreateCourseModelApi()
                { 
                    name = "FrontedCourse",
                    description = "FrontedCourse"
                };
            }
        }
        
        public static CreateCourseModelApi createBackendCourse
        {
            get
            {
                return new CreateCourseModelApi()
                { 
                    name = "BackendCourse",
                    description = "BackendCourse"
                };
            }
        }
        
        public static CreateCourseModelApi createQAACourse
        {
            get
            {
                return new CreateCourseModelApi()
                { 
                    name = "QAACourse",
                    description = "QAACourse"
                };
            }
        }

        public static CreateGroupeModelApi createGroupe
        {
            get
            {
                return new CreateGroupeModelApi()
                {
                    name = "Haikyuu!",
                    courseId = 0,
                    groupStatusId = "Forming",
                    startDate = "25.12.2022",
                    endDate = "25.03.2023",
                    timetable = "string",
                    paymentPerMonth = 5000,
                    paymentsCount = 6
                };
            }
        }

        public static TaskRequestModelApi createTask1
        {
            get
            {
                return new TaskRequestModelApi()
                {
                    name = "List all variables1",
                    description = "List all variables and their types",
                    links = "string.com",
                    isRequired = true,
                    groupId = 0
                };
            }
        }

        public static HomeworkRequestModelApi createHomework1
        {
            get
            {
                return new HomeworkRequestModelApi()
                {
                    startDate = "25.12.2022",
                    endDate = "25.03.2022"
                };
            }
        }
    }
}
