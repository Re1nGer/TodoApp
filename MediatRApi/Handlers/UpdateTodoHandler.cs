using AutoMapper;
using MediatR;
using MediatRApi.Commands.UpdateComman;
using MediatRApi.Controllers.V1.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;
using TodoLibrary.Models;
using TodoServices.Interfaces;

namespace MediatRApi.Handlers
{
    public class UpdateTodoHandler : IRequestHandler<UpdateTodoCommand, int>
    {
        private readonly ITodoService _service;
        private readonly IMapper _mapper;

        public UpdateTodoHandler(ITodoService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<int> Handle(UpdateTodoCommand request, CancellationToken cancellationToken)
        {
            var tryToFind = _service.GetTodoById(request.updateRequest.Id);

            if(tryToFind is null)
            {
                throw new Exception($"Record with Id {request.updateRequest.Id} couldn't be found");
            }

            var updateEntity = _mapper.Map<Todo>(request.updateRequest);

             _service.UpdateTodo(updateEntity);

             return _mapper.Map<UpdateTodoItemResponse>(updateEntity).Id;
        }
    }
}
