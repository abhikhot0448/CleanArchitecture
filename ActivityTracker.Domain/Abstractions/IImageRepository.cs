using ActivityTracker.Domain.Entities;

namespace ActivityTracker.Domain.Abstractions;

public interface IImageRepository
{
    #region Methods
    Task<IEnumerable<Image>> GetAllImagesAsync();
    Task<Image> GetImageByIdAsync(Guid id);
    Task<Image> AddImageAsync(Image image);
    Task<Image> UpdateImageAsync(Image image);
    Task<bool> DeleteImageAsync(Guid imageId);
    #endregion
}
