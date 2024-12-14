using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Domain.Entities;
using ActivityTracker.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ActivityTracker.Infrastructure.Repositories;

public class GoalRepository : IGoalRepository
{
    #region Properties
    private readonly ApplicationDbContext _dbContext;
    #endregion

    #region Constructor
    public GoalRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;
    #endregion

    #region Methods
    public async Task<IEnumerable<Goal>> GetGoalsAsync() => await _dbContext.Goals.ToListAsync();

    public async Task<Goal> GetGoalByIdAsync(Guid id)
    {
        return await _dbContext.Goals
                               .Where(goal => goal.Id == id)
                               .FirstOrDefaultAsync();
    }

    public async Task<Goal> AddGoalAsync(Goal goal)
    {
        _dbContext.Goals.Add(goal);
        await _dbContext.SaveChangesAsync();
        return goal;
    }

    public async Task<Goal> UpdateGoalAsync(Goal goal)
    {
        var goalToUpdate = await GetGoalByIdAsync(goal.Id);
        if (goalToUpdate != null)
        {
            goalToUpdate.UserId = goal.UserId;
            goalToUpdate.ActivityType = goal.ActivityType;
            goalToUpdate.TargetValue = goal.TargetValue;
            goalToUpdate.TimePeriod = goal.TimePeriod;
            goalToUpdate.StartDate = goal.StartDate;
            goalToUpdate.EndDate = goal.EndDate;
            _dbContext.Goals.Update(goalToUpdate);
            await _dbContext.SaveChangesAsync();
        }
        return goal;
    }

    public async Task<bool> DeleteGoalAsync(Guid goalId)
    {
        var goal = await GetGoalByIdAsync(goalId);
        if (goal == null) return false;

        _dbContext.Goals.Remove(goal);
        await _dbContext.SaveChangesAsync();
        return true;
    }
    #endregion
}
