using Scaffold.Domain.Models;
using MediatR;

namespace Scaffold.Domain.Queries
{
    public class GetApiInfoQuery : IRequest<ApiInfo>
    {
        public bool? IsValid { get; set; }
    }
}
