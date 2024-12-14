using ActivityTracker.Domain.Abstractions;
using MediatR;

namespace ActivityTracker.Application.Images.Commands.DeleteImages;

public class DeleteImageCommandHandler : IRequestHandler<DeleteImageCommand, bool>
{
    #region Properties
    private readonly IImageRepository _imageRepository;
    #endregion

    #region Constructor
    public DeleteImageCommandHandler(IImageRepository imageRepository) => _imageRepository = imageRepository;
    #endregion

    #region Methods
    public async Task<bool> Handle(DeleteImageCommand request, CancellationToken cancellationToken)
    {
        return await _imageRepository.DeleteImageAsync(request.ImageId);
    }
    #endregion
}
