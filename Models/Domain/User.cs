namespace JeepCity.Models.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string subject { get; set; }
        public string feedback { get; set; }
    }
}
