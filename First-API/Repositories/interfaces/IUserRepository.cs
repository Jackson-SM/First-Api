using First_API.Models;

namespace First_API.Repositories.interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetById(Guid id);
        Task<User> Create(User user);
        Task<User> Update(User user);
        Task<bool> Delete(Guid id);
    }
}
