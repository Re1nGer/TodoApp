using MediatR;
using MediatRApi.Queries.GetAllTodoList;
using System.Collections.Generic;

namespace MediatRApi.Queries
{
    public class GetAllTodosQuery : IRequest<GetAllTodosResponse>
    {

    }
}
