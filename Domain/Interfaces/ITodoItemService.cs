using LanguageExt;
using LanguageExt.Common;

namespace Domain.Interfaces;

public interface ITodoItemService
{
    Task<ITodoItemId> CreateTodoItemAsync(ITodoItemSave item);
    Task<Option<ITodoItem>> ReadTodoItemAsync(ITodoItemId todoItemId);
    Task<Result<DateTime>> UpdateTodoItemAsync(ITodoItemId todoItemId, ITodoItem item);
}