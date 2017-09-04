namespace src.Models
{
    public interface IUserService
    {
         UserDto Get(string email);
    }
}