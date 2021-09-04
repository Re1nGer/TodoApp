using MediatRApi.Commands;
using MediatRApi.Commands.DeleteCommand;
using MediatRApi.Commands.UpdateComman;
using MediatRApi.Controllers.V1.Requests;
using MediatRApi.Queries;
using MediatRApi.V1.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MediatRApi.Controllers
{
    [ApiVersion("1.0")]
    public class TodoController : BaseController
    {
        [HttpGet("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllTodosQuery();
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpPost("")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CreateTodo([FromBody] CreateTodo createRequest)
        {
            var command = new CreateTodoCommand(createRequest);
            var result = await Mediator.Send(command);
            return CreatedAtAction(nameof(GetTodoById), new {todoId = result}, result);
        }

        [HttpGet("{todoId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetTodoById([FromRoute]int todoId)
        {
            var query = new GetTodoByIdQuery(todoId);
            var result = await Mediator.Send(query);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPut("")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> UpdateTodo([FromBody]UpdateTodo todoItem)
        {
            var command = new UpdateTodoCommand(todoItem);
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{todoId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteTodo([FromRoute]int todoId)
        {
            var command = new DeleteTodoCommand(todoId);
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}
