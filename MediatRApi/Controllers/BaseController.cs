using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace MediatRApi.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BaseController : ControllerBase
    {
        private IMediator _mediatr;
        protected IMediator Mediator => _mediatr ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}
