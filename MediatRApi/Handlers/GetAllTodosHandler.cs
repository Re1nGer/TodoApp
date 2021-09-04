using AutoMapper;
using MediatR;
using MediatRApi.Queries;
using MediatRApi.Queries.GetAllTodoList;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TodoServices.Interfaces;

namespace MediatRApi.Handlers
{
    public class GetAllTodosHandler : IRequestHandler<GetAllTodosQuery, GetAllTodosResponse>
    {
        private readonly IMapper _mapper;
        private readonly ITodoService _service;

        public GetAllTodosHandler(IMapper mapper, ITodoService service)
        {
            _mapper = mapper;
            _service = service;
        }

        public Task<GetAllTodosResponse> Handle(GetAllTodosQuery request, CancellationToken cancellationToken)
        {
            var todos =  _service.GetAllTodos();
            var listTodos = _mapper.Map<List<TodoDTO>>(todos);

           return Task.FromResult(new GetAllTodosResponse
            {
                Todos = listTodos
            });
        }
    }
}
