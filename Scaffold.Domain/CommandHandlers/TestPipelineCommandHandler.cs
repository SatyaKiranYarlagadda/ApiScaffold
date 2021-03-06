﻿using System.Threading;
using System.Threading.Tasks;
using Scaffold.Domain.Commands;
using Scaffold.Domain.Exceptions;
using Scaffold.Domain.Models;
using HCF.Common.Foundation.CQRSExtensions;
using MediatR;

namespace Scaffold.Domain.CommandHandlers
{
    public class TestPipelineCommandHandler : IRequestHandler<TestPipelineCommand, ICommandResult>
    {
        public async Task<ICommandResult> Handle(TestPipelineCommand request, CancellationToken cancellationToken)
        {
            if (request.IsValid.HasValue && request.IsValid == true)
            {
                return await Task.FromResult(new TestPipelineResult
                {
                    IsSuccess = true,
                    Result = "Healthy"
                });
            }
            else
            {
                throw new TestException();
            }
        }
    }
}
