using MediatR;

namespace Furino.Application.Commands.CreateToDo
{
    public class CreateToDoItemCommand : IRequest<int>
    {
        public required string Description { get; set; }
    }
}
