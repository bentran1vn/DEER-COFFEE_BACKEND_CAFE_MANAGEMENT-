using DeerCoffeeShop.Application.Common.Interfaces;
using MediatR.Pipeline;
using Microsoft.Extensions.Logging;

namespace DeerCoffeeShop.Application.Common.Behaviours
{
    public class LoggingBehaviour<TRequest>(ILogger<TRequest> logger, ICurrentUserService currentUserService) : IRequestPreProcessor<TRequest>
         where TRequest : notnull
    {
        private readonly ILogger _logger = logger;

        public Task Process(TRequest request, CancellationToken cancellationToken)
        {
            var requestName = typeof(TRequest).Name;
            var userId = currentUserService.UserId ?? string.Empty;
            var userName = currentUserService.UserName ?? string.Empty;

            _logger.LogInformation("TestCA9 Request: {Name} {@UserId} {@UserName} {@Request}",
                requestName, userId, userName, request);
            return Task.CompletedTask;
        }
    }
}
