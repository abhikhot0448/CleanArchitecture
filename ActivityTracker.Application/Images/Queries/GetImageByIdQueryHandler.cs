using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Images.Queries;

public class GetImageByIdQueryHandler : IRequestHandler<GetImageByIdQuery, Image>
{
    #region Properties
    private readonly IImageRepository _imageRepository;
    #endregion

    #region Constructor
    public GetImageByIdQueryHandler(IImageRepository imageRepository) => _imageRepository = imageRepository;
    #endregion

    #region Methods
    public async Task<Image> Handle(GetImageByIdQuery request, CancellationToken cancellationToken)
    {
        return await _imageRepository.GetImageByIdAsync(request.ImageId);
    }
    #endregion
}
