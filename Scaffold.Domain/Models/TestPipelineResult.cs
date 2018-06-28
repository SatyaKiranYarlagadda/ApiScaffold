using HCF.Common.Foundation.CQRSExtensions;

namespace Scaffold.Domain.Models
{
    public class TestPipelineResult : ICommandResult
    {
        public bool IsSuccess { get; set; }

        public bool IsFailure { get; set; }

        public object Result { get; set; }
    }
}
