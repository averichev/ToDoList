namespace Domain.Interfaces;

public interface ITodoItemService
{
    Task<ITodoItemId> CreateTodoItemAsync(ITodoItemCreate item);
}