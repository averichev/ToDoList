using Domain.Interfaces;

namespace Domain.Services;

internal class UserService: IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<IUserId> CreateUserAsync(IUserCreate userCreate)
    {
        return await _userRepository.SaveUserAsync(userCreate);
    }
}