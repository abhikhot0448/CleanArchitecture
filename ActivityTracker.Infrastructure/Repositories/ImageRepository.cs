using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Domain.Entities;
using ActivityTracker.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ActivityTracker.Infrastructure.Repositories;

public class ImageRepository : IImageRepository
{
    #region Properties
    private readonly ApplicationDbContext _dbContext;
    #endregion

    #region Constructor
    public ImageRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;
    #endregion

    #region Methods
    public async Task<IEnumerable<Image>> GetAllImagesAsync() => await _dbContext.Images.ToListAsync();

    public async Task<Image> GetImageByIdAsync(Guid id)
    {
        return await _dbContext.Images
                               .Where(image => image.Id == id)
                               .FirstOrDefaultAsync();
    }

    public async Task<Image> AddImageAsync(Image image)
    {
        _dbContext.Images.Add(image);
        await _dbContext.SaveChangesAsync();
        return image;
    }

    public async Task<Image> UpdateImageAsync(Image image)
    {
        var imageToUpdate = await GetImageByIdAsync(image.Id);
        if (imageToUpdate != null)
        {
            imageToUpdate.Url = image.Url;
            imageToUpdate.ActivityId = image.ActivityId;
            imageToUpdate.UserId = image.UserId;
            imageToUpdate.UploadedAt = image.UploadedAt;
            _dbContext.Images.Update(imageToUpdate);
            await _dbContext.SaveChangesAsync();
        }
        return image;
    }

    public async Task<bool> DeleteImageAsync(Guid imageId)
    {
        var image = await GetImageByIdAsync(imageId);
        if (image == null) return false;

        _dbContext.Images.Remove(image);
        await _dbContext.SaveChangesAsync();
        return true;
    }
    #endregion
}
