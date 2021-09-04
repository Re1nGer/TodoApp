using MediatR;
using MediatRApi.Commands.DeleteCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TodoServices.Interfaces;

namespace MediatRApi.Handlers
{
    public class DeleteTodoHandler : IRequestHandler<DeleteTodoCommand, int>
    {
        private readonly ITodoService _service;

        public DeleteTodoHandler(ITodoService service)
        {
            _service = service;
        }

        public async Task<int> Handle(DeleteTodoCommand request, CancellationToken cancellationToken)
        {
            var tryToFind = _service.GetTodoById(request.Id);

            if(tryToFind is null)
            {
                throw new Exception($"Entity with Id {request.Id} not found");
            }
            _service.DeleteTodo(request.Id);

            return request.Id;
        }
    }
}
