
namespace LMSTestingProjectQAABaku
{
    public class IdStorage
    {
        public int studentId { get; set; }
        public int teacherId { get; set; }
        public int tutorId { get; set; }
        public int methodistId { get; set; }
        public string adminToken { get; set; }
        public string teacherToken { get; set; }
        public int courseIdBaseCourse { get; set; }
        public int courseIdFrontend { get; set; }
        public int courseIdBackend { get; set; }
        public int courseIdQAA { get; set; }

        public int taskId { get; set; }
        public int groupId { get; set; }


        private static IdStorage _instance; //переменная для хранения ссылки на единств объект класса
        private IdStorage() //для создания всего одного объекта, создаём приватный конструктор
        {
        }

        public static IdStorage CreateInstance() //для добавления элементов
        {
            if (_instance == null)
            {
                _instance = new IdStorage();
            }
            return _instance;
        }
    }
}
