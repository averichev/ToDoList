using LanguageExt;
using LanguageExt.Common;

namespace Domain.Interfaces;

public interface ITodoItemRepository
{
    Task<ITodoItemId> CreateTodoItemAsync(ITodoItemSave item);
    Task<Option<ITodoItem>> ReadTodoItemAsync(ITodoItemId id);
    Task<Result<DateTime>> UpdateTodoItemAsync(ITodoItem item);
}