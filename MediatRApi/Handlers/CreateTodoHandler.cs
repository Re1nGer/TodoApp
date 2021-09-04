using AutoMapper;
using MediatR;
using MediatRApi.Commands;
using MediatRApi.V1.Responses;
using System.Threading;
using System.Threading.Tasks;
using TodoLibrary.Models;
using TodoServices.Interfaces;

namespace MediatRApi.Handlers
{
    public class CreateTodoHandler : IRequestHandler<CreateTodoCommand, int>
    {
        private readonly ITodoService  _service;
        private readonly IMapper _autoMapper;

        public CreateTodoHandler(ITodoService service, IMapper autoMapper)
        {
            _service = service;
            _autoMapper = autoMapper;
        }

        public Task<int> Handle(CreateTodoCommand request, CancellationToken cancellationToken)
        {
            var todoEntity = _autoMapper.Map<Todo>(request.createRequest);

             _service.CreateTodo(todoEntity);

            return Task.FromResult(_autoMapper.Map<CreatedTodoResponse>(todoEntity).Id);
        }

    }
}
