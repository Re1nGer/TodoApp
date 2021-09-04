using MediatR;
using MediatRApi.Controllers.V1.Requests;

namespace MediatRApi.Commands.UpdateComman
{
    public class UpdateTodoCommand : IRequest<int>
    {
        public UpdateTodo updateRequest { get; }

        public UpdateTodoCommand(UpdateTodo updateRequest)
        {
            this.updateRequest = updateRequest;
        }
    }
}
