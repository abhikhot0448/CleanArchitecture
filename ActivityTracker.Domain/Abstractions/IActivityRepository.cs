using ActivityTracker.Domain.Entities;

namespace ActivityTracker.Domain.Abstractions;

public interface IActivityRepository
{
    #region Methods
    Task<IEnumerable<Activity>> GetActivitiesAsync();
    Task<Activity> GetActivityByIdAsync(Guid id);
    Task<Activity> AddActivityAsync(Activity activity);
    Task<Activity> UpdateActivityAsync(Activity activity);
    Task<bool> DeleteActivityAsync(Guid activityId);
    #endregion
}
