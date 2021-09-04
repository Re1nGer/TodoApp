using MediatRApi.V1.Responses;

namespace MediatRApi.Controllers.V1.Responses
{
    public class GetTodoByIdResponse : BaseResponse
    {
        public string Description { get; set; }
        public bool IsDone { get; set; }
    }
}
