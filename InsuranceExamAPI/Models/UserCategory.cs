namespace InsuranceExamAPI.Models
{
    public class UserCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<User>? User { get; set; }
    }
}
