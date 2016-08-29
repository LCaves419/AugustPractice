namespace WebApplication9.Models
{
    public class Contacts
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Contacts()
        {
            Id = -1;
            FirstName = string.Empty;
            LastName = string.Empty;

        }
    }
}