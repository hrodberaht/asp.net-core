namespace src.Models
{
    public class User
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public User() 
        {
        }

        public User(string email, string name, string password )
        {
            Email = email.ToLowerInvariant();
            Name = name;
            Password = password;
        }



    }
}