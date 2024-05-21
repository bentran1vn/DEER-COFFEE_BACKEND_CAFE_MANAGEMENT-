﻿using DeerCoffeeShop.Application.Common.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace DeerCoffeeShop.Application.Common.Behaviours
{
    public class PerformanceBehaviour<TRequest, TResponse>(
        ILogger<TRequest> logger,
        ICurrentUserService currentUserService) : IPipelineBehavior<TRequest, TResponse>
         where TRequest : notnull
    {
        private readonly Stopwatch _timer = new();

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            _timer.Start();

            var response = await next();

            _timer.Stop();

            var elapsedMilliseconds = _timer.ElapsedMilliseconds;

            if (elapsedMilliseconds > 500)
            {
                var requestName = typeof(TRequest).Name;
                var userId = currentUserService.UserId ?? string.Empty;
                var userName = currentUserService.UserName ?? string.Empty;

                logger.LogWarning("DeerCoffeeShop Long Running Request: {Name} ({ElapsedMilliseconds} milliseconds) {@UserId} {@UserName} {@Request}",
                    requestName, elapsedMilliseconds, userId, userName, request);
            }

            return response;
        }
    }
}
