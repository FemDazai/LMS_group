namespace LMSTestingProjectQAABaku.Models
{
    public class RegistrationRequestModel
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string BirthDate { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        internal object ToList()
        {
            throw new NotImplementedException();
        }
    }
}
