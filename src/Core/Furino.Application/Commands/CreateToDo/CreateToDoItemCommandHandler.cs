using Furino.Domain.Entities;
using Furino.Domain.Interfaces;
using MediatR;

namespace Furino.Application.Commands.CreateToDo
{
    public class CreateToDoItemCommandHandler(IToDoRepository toDoRepository)
    : IRequestHandler<CreateToDoItemCommand, int>
    {
        public Task<int> Handle(
            CreateToDoItemCommand request, CancellationToken cancellationToken)
        {
            var item = new ToDoItem
            {
                Description = request.Description
            };

            return toDoRepository.CreateAsync(item);
        }
    }
}
