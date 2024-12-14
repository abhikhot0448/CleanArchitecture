using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Images.Commands.AddImages;

public class AddImageCommandHandler : IRequestHandler<AddImageCommand, Image>
{
    #region Properties
    private readonly IImageRepository _imageRepository;
    #endregion

    #region Constructor
    public AddImageCommandHandler(IImageRepository imageRepository) => _imageRepository = imageRepository;
    #endregion

    #region Methods
    public async Task<Image> Handle(AddImageCommand request, CancellationToken cancellationToken)
    {
        return await _imageRepository.AddImageAsync(request.Image);
    }
    #endregion
}
