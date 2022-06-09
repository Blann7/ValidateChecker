namespace ValidateChecker.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Role { get; set; }
        public string? RoleValidityDate { get; set; }
        public string? BanDate { get; set; }
        public int Money { get; set; }
    }
}
