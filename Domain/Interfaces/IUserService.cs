namespace Domain.Interfaces;

public interface IUserService
{
    Task<IUserId> CreateUserAsync(IUserCreate userCreate);
}