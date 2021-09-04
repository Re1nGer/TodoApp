using MediatR;

namespace MediatRApi.Commands.DeleteCommand
{
    public class DeleteTodoCommand : IRequest<int>
    {
        public int Id { get;}
        public DeleteTodoCommand(int Id)
        {
            this.Id = Id;
        }
    }
}
