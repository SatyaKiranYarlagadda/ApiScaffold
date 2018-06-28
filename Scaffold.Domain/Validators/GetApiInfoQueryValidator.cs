using FluentValidation;
using Scaffold.Domain.Queries;

namespace Scaffold.Domain.Validators
{
    public class GetApiInfoQueryValidator : AbstractValidator<GetApiInfoQuery>
    {
        public GetApiInfoQueryValidator()
        {
            RuleFor(query => query.IsValid).NotNull().Must(x => x == true);
        }
    }
}
