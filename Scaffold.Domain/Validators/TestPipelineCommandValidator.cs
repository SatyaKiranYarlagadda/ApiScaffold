using FluentValidation;
using Scaffold.Domain.Commands;

namespace Scaffold.Domain.Validators
{
    public class TestPipelineCommandValidator : AbstractValidator<TestPipelineCommand>
    {
        public TestPipelineCommandValidator()
        {
            RuleFor(query => query.IsValid).NotNull().Must(x => x == true);
        }
    }
}
