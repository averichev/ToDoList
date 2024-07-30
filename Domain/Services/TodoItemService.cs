using Domain.Exceptions;
using Domain.Interfaces;
using LanguageExt;
using LanguageExt.Common;

namespace Domain.Services;

internal class TodoItemService : ITodoItemService
{
    private readonly ITodoItemRepository _repository;

    public TodoItemService(ITodoItemRepository repository)
    {
        _repository = repository;
    }

    public async Task<ITodoItemId> CreateTodoItemAsync(ITodoItemSave item)
    {
        return await _repository.CreateTodoItemAsync(item);
    }

    public async Task<Option<ITodoItem>> ReadTodoItemAsync(ITodoItemId todoItemId)
    {
        return await _repository.ReadTodoItemAsync(todoItemId);
    }

    public async Task<Result<DateTime>> UpdateTodoItemAsync(ITodoItemId todoItemId, ITodoItem item)
    {
        var exist = await _repository.ReadTodoItemAsync(todoItemId);
        var match = await exist.MatchAsync(
            i => _repository.UpdateTodoItemAsync(i),
            () => Task.FromResult(new Result<DateTime>(new DomainException("Не найдена задача")))
        );
        return match;
    }
}