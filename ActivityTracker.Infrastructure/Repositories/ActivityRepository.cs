using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Domain.Entities;
using ActivityTracker.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ActivityTracker.Infrastructure.Repositories;

public class ActivityRepository : IActivityRepository
{
    #region Properties
    private readonly ApplicationDbContext _dbContext;
    #endregion

    #region Constructor
    public ActivityRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;
    #endregion

    #region Methods
    public async Task<IEnumerable<Activity>> GetActivitiesAsync() => await _dbContext.Activities.ToListAsync();

    public async Task<Activity> GetActivityByIdAsync(Guid id)
    {
        return await _dbContext.Activities
                               .Where(activity => activity.Id == id)
                               .FirstOrDefaultAsync();
    }

    public async Task<Activity> AddActivityAsync(Activity activity)
    {
        _dbContext.Activities.Add(activity);
        await _dbContext.SaveChangesAsync();
        return activity;
    }

    public async Task<Activity> UpdateActivityAsync(Activity activity)
    {
        var activityToUpdate = await GetActivityByIdAsync(activity.Id);
        if (activityToUpdate != null)
        {
            activityToUpdate.UserId = activity.UserId;
            activityToUpdate.ActivityTypeId = activity.ActivityTypeId;
            activityToUpdate.Description = activity.Description;
            activityToUpdate.StartTime = activity.StartTime;
            activityToUpdate.EndTime = activity.EndTime;
            activityToUpdate.ImageUrl = activity.ImageUrl;
            _dbContext.Activities.Update(activityToUpdate);
            await _dbContext.SaveChangesAsync();
        }
        return activity;
    }

    public async Task<bool> DeleteActivityAsync(Guid activityId)
    {
        var activity = await GetActivityByIdAsync(activityId);
        if (activity == null) return false;

        _dbContext.Activities.Remove(activity);
        await _dbContext.SaveChangesAsync();
        return true;
    }
    #endregion
}
