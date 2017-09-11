using System.Collections.Generic;
using System.Linq;

namespace src.Models
{
    public class FakeUserRepository : IUserRepository
    {
        public IEnumerable<User> Users => new List<User>
        {
            new User{Email = "jack@gmail.com", Name = "Jack"},
            new User{Email = "jon@gmail.com", Name = "Jon"},
            new User{Email = "rob@gmail.com", Name = "Rob"},
            new User{Email = "tom@gmail.com", Name = "Tom"},


        };
        public User GetUser(string email) 
            => Users.First(x => x.Email == email.ToLowerInvariant());
        
    }
}