using MediatR;

namespace Furino.Application.Queries.ToDoItem
{
    public class ToDoItemQuery
        : IRequest<List<Domain.Entities.ToDoItem>>
    {
    }
}
