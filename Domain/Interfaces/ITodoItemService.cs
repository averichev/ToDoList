using Optional;

namespace Domain.Interfaces;

public interface ITodoItemService
{
    Task<ITodoItemId> CreateTodoItemAsync(ITodoItemCreate item);
    Task<Option<ITodoItem>> ReadTodoItemAsync(ITodoItemId todoItemId);
}