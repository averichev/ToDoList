using Domain.Interfaces;
using Optional;

namespace Domain.Services;

internal class TodoItemService : ITodoItemService
{
    private readonly ITodoItemRepository _repository;
    public TodoItemService(ITodoItemRepository repository)
    {
        _repository = repository;
    }
    public async Task<ITodoItemId> CreateTodoItemAsync(ITodoItemCreate item)
    {
        return await _repository.CreateTodoItemAsync(item);
    }

    public async Task<Option<ITodoItem>> ReadTodoItemAsync(ITodoItemId todoItemId)
    {
        return await _repository.ReadTodoItemAsync(todoItemId);
    }
}