using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Domain.Entities;
using ActivityTracker.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ActivityTracker.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    #region Properties
    public ApplicationDbContext _dbContext {  get; set; }
    #endregion

    #region Constructor
    public UserRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;
   
    #endregion

    #region Methods
    public async Task<IEnumerable<User>> GetUsersAsync() => await _dbContext.Users.ToListAsync();

    public async Task<User> GetUserByIdAsync(Guid id)
    {
        return await _dbContext.Users
                        .Where(user => user.Id == id)
                        .FirstOrDefaultAsync();
    }
    
    public async Task<User> AddUserAsync(User user)
    {
        _dbContext.Users.Add(user);

        await _dbContext.SaveChangesAsync();

        return user;
    }

    public async Task<User> UpdateUserAsync(User user)
    {
        var userToUpdate = await GetUserByIdAsync(user.Id);
        if (userToUpdate != null) 
        {
            userToUpdate.Name = user.Name;
            userToUpdate.Email = user.Email;
            userToUpdate.Password = user.Password;
            await _dbContext.SaveChangesAsync();
            _dbContext.Users.Update(user);
        }
        return user;
    }

    public async Task<bool> DeleteUserAsync(Guid userId)
    {
        var user = await GetUserByIdAsync(userId);

        if (user == null) return false;

        _dbContext.Users.Remove(user);
        await _dbContext.SaveChangesAsync();
        return true; 
    }
    #endregion
}
