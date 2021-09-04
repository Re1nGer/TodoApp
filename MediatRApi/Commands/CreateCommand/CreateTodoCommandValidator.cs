using FluentValidation;
using MediatRApi.V1.Requests;

namespace MediatRApi.Commands
{
    public class CreateTodoCommandValidator : AbstractValidator<CreateTodoCommand>
    {
        public CreateTodoCommandValidator()
        {
            RuleFor(x => x.createRequest.Description).NotEmpty();
            RuleFor(x => x.createRequest.IsDone).NotNull();
        }
    }
}
