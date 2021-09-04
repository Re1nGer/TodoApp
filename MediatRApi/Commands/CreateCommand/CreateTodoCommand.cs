using MediatR;
using MediatRApi.V1.Requests;
using MediatRApi.V1.Responses;

namespace MediatRApi.Commands
{
    public class CreateTodoCommand : IRequest<int>
    {
        public CreateTodo createRequest { get; }
        public CreateTodoCommand(CreateTodo createRequest)
        {
            this.createRequest = createRequest;
        }
    }
}
