using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Images.Commands.UpdateImages;

public class UpdateImageCommandHandler : IRequestHandler<UpdateImageCommand, Image>
{
    #region Properties
    private readonly IImageRepository _imageRepository;
    #endregion

    #region Constructor
    public UpdateImageCommandHandler(IImageRepository imageRepository) => _imageRepository = imageRepository;
    #endregion

    #region Methods
    public async Task<Image> Handle(UpdateImageCommand request, CancellationToken cancellationToken)
    {
        return await _imageRepository.UpdateImageAsync(request.Image);
    }
    #endregion
}
