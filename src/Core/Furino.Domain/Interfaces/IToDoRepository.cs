using Furino.Domain.Entities;

namespace Furino.Domain.Interfaces
{
    public interface IToDoRepository
    {
        Task<List<ToDoItem>> GetAllAsync();
        Task<int> CreateAsync(ToDoItem item);
    }
}
