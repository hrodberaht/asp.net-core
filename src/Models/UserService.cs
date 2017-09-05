namespace src.Models
{
    public class UserServices : IUserService
    {
       private readonly IUserRepository _userRepository;

       public UserServices(IUserRepository userRepository)
       {
           _userRepository = userRepository;
       }

        public UserDto Get(string email)
        {
            var user = _userRepository.GetUser(email);

            return new UserDto {
                Name = user.Name
            };
        }
    }
}