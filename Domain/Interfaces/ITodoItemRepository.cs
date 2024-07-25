namespace Domain.Interfaces;

public interface ITodoItemRepository
{
    Task<ITodoItemId> CreateTodoItemAsync(ITodoItemCreate item);
}