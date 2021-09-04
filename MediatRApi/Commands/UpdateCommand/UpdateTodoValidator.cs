using FluentValidation;

namespace MediatRApi.Commands.UpdateComman
{
    public class UpdateTodoValidator : AbstractValidator<UpdateTodoCommand>
    {
        public UpdateTodoValidator()
        {
            RuleFor(x => x.updateRequest.Id).NotEmpty();
        }
    }
}
