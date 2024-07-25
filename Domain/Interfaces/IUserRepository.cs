namespace Domain.Interfaces;

public interface IUserRepository
{
    Task<IUserId> SaveUserAsync(IUserCreate userCreate);
}