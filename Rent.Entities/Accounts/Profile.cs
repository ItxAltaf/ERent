namespace Rent.Entities.Accounts
{
    public class Profile
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
    }
}