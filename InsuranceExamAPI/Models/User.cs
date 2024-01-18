namespace InsuranceExamAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserCategoryId { get; set; }
        public UserCategory? UserCategory { get; set; }
    }
}
