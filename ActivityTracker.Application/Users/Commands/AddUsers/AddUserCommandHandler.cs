using ActivityTracker.Domain.Abstractions;
using ActivityTracker.Domain.Entities;
using MediatR;

namespace ActivityTracker.Application.Users.Commands.AddEmployees
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, User>
    {
        #region Properties
        private readonly IUserRepository _userRepository;
        #endregion

        #region Constructor
        public AddUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        #endregion

        #region Methods
        public async Task<User> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
           return await _userRepository.AddUserAsync(request.User);
        }
        #endregion
    }
}
