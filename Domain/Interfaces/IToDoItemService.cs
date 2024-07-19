namespace Domain.Interfaces;

public interface IToDoItemService
{
    Task<IToDoItemId> CreateToDoItemAsync(IToDoItemCreate item);
}