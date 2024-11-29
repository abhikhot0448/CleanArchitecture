using ActivityTracker.Domain.Abstractions;
using MediatR;

namespace ActivityTracker.Application.Users.Commands.DeleteUsers;

public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, bool>
{
    #region Properties
    private readonly IUserRepository _userRepository;
    #endregion

    #region Constructor
    public DeleteUserCommandHandler(IUserRepository userRepository) => _userRepository = userRepository;
    #endregion

    #region Methods
    public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        return await _userRepository.DeleteUserAsync(request.userId);
    }
    #endregion

}
