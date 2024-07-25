using Optional;

namespace Domain.Interfaces;

public interface ITodoItemRepository
{
    Task<ITodoItemId> CreateTodoItemAsync(ITodoItemCreate item);
    Task<Option<ITodoItem>> ReadTodoItemAsync(ITodoItemId todoItemId);
}