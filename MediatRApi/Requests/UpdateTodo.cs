using MediatRApi.Requests;

namespace MediatRApi.Controllers.V1.Requests
{
    public class UpdateTodo : BaseRequest
    {
        public int Id { get; set; }
    }
}
