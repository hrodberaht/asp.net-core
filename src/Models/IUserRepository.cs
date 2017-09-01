namespace src.Models
{
    public interface IUserRepository
    {
         User GetUser(string email);
    }
}