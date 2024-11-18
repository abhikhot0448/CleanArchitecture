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
        _dbContext.Users.Add(user);

        await _dbContext.SaveChangesAsync();

        return user;
    }

    public async Task<User> DeleteUserAsync(Guid userId)
    {
        var user = await GetUserByIdAsync(userId);
        _dbContext.Users.Remove(user);
        await _dbContext.SaveChangesAsync();

        return user;
    }
    #endregion
}
