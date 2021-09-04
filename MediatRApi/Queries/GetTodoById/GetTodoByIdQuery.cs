using MediatR;
using MediatRApi.Controllers.V1.Responses;

namespace MediatRApi.Queries
{
    public class GetTodoByIdQuery : IRequest<GetTodoByIdResponse>
    {
        public  int Id { get; }

        public GetTodoByIdQuery(int Id)
        {
            this.Id = Id;
        }
    }
}
