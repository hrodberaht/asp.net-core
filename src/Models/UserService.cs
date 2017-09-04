namespace src.Models
{
    public class UserServices : IUserService
    {
       private readonly IUserRepository _userRepository;

       public UserServices(FakeUserRepository userRepository)
       {
           _userRepository = userRepository;
       }

        public UserDto Get(string email)
        {
            var user = _userRepository.GetUser(email);

            return new UserDto {
                Email = user.Email
            };
        }
    }
}