using System.Threading;
using System.Threading.Tasks;
using Scaffold.Domain.Models;
using Scaffold.Domain.Queries;
using MediatR;

namespace Scaffold.Domain.QueryHandlers
{
    public class GetApiInfoQueryHandler : IRequestHandler<GetApiInfoQuery, ApiInfo>
    {
        public async Task<ApiInfo> Handle(GetApiInfoQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new ApiInfo
            {
                ApiName = "[TBD-ApiName]",
                ApiVersion = "[TBD-ApiVersion]"
            });
        }
    }
}
