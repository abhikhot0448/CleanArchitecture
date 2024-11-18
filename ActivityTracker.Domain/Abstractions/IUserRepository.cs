using ActivityTracker.Domain.Entities;

namespace ActivityTracker.Domain.Abstractions;

public interface IUserRepository
{
    #region Methods
    Task<IEnumerable<User>> GetUsersAsync();
    Task<User> GetUserByIdAsync(Guid id);
    Task<User> AddUserAsync(User user);
    Task<User> UpdateUserAsync(User user);
    Task<User> DeleteUserAsync(Guid userId);
    #endregion
}
