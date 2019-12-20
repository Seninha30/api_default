namespace Default.Domain.Interfaces
{
    public class UserRequest
    {
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public int Status { get; set; }
    }
}
