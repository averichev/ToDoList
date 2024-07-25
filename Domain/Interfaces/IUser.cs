namespace Domain.Interfaces;

public interface IUser
{
    public IUserId Id { get; }
    public string Username { get; }
}