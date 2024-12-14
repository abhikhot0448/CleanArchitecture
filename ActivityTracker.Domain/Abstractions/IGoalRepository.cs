using ActivityTracker.Domain.Entities;

namespace ActivityTracker.Domain.Abstractions;
public interface IGoalRepository
{
    #region Methods
    Task<IEnumerable<Goal>> GetGoalsAsync();
    Task<Goal> GetGoalByIdAsync(Guid id);
    Task<Goal> AddGoalAsync(Goal goal);
    Task<Goal> UpdateGoalAsync(Goal goal);
    Task<bool> DeleteGoalAsync(Guid goalId);
    #endregion
}
