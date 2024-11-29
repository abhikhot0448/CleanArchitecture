using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Users.Commands.UpdateUsers;

public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, User>
{
    #region Properties
    private readonly IUserRepository _userRepository;
    #endregion

    #region Constructor
    public UpdateUserCommandHandler(IUserRepository userRepository) => _userRepository = userRepository;
    #endregion

    #region Methods
    public async Task<User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        return await _userRepository.UpdateUserAsync(request.user);
    }
    #endregion
}
