using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Images.Queries;

public class GetAllImagesQueryHandler : IRequestHandler<GetAllImagesQuery, IEnumerable<Image>>
{
    #region Properties
    private readonly IImageRepository _imageRepository;
    #endregion

    #region Constructor
    public GetAllImagesQueryHandler(IImageRepository imageRepository) => _imageRepository = imageRepository;
    #endregion

    #region Methods
    public async Task<IEnumerable<Image>> Handle(GetAllImagesQuery request, CancellationToken cancellationToken)
    {
        return await _imageRepository.GetAllImagesAsync();
    }
    #endregion
}
