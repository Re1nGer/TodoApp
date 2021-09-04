using AutoMapper;
using MediatR;
using MediatRApi.Controllers.V1.Responses;
using MediatRApi.Queries;
using System.Threading;
using System.Threading.Tasks;
using TodoServices.Interfaces;

namespace MediatRApi.Handlers
{
    public class GetTodoByIdHandler : IRequestHandler<GetTodoByIdQuery, GetTodoByIdResponse>
    {
        private readonly ITodoService _service;
        private readonly IMapper _autoMapper;

        public GetTodoByIdHandler(ITodoService service, IMapper autoMapper)
        {
            _service = service;
            _autoMapper = autoMapper;
        }

        public async Task<GetTodoByIdResponse> Handle(GetTodoByIdQuery request, CancellationToken cancellationToken)
        {
            var retrievedTodoItem = _service.GetTodoById(request.Id);
            return _autoMapper.Map<GetTodoByIdResponse>(retrievedTodoItem);
        }
    }
}
