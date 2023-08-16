using First_API.Data;
using First_API.Models;
using First_API.Repositories.interfaces;
using Microsoft.EntityFrameworkCore;

namespace First_API.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly UserDbContext _dbContext;

        public UserRepository(UserDbContext userDbContext)
        {
            _dbContext = userDbContext;
        }

        public async Task<User> Create(User user)
        {
            await _dbContext.Users.AddAsync(user);

            await _dbContext.SaveChangesAsync();

            return user;
        }

        public async Task<bool> Delete(Guid id)
        {
            User userById = await GetById(id);

            if (userById == null)
            {
                throw new Exception($"User id: {id} not found");
            }

            _dbContext.Users.Remove(userById);
            await _dbContext.SaveChangesAsync();

            return true;
        }
        public async Task<User> Update(User user)
        {
            User userById = await GetById(user.Id);

            if(userById == null)
            {
                throw new Exception($"User id: {user.Id} not found");
            }

            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();

            return user;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User> GetById(Guid id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(user => user.Id == id);
        }

    }
}
