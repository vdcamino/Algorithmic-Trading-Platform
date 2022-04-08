using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using System;
using System.Threading;
using System.Threading.Tasks;

using Trading_Engine_Server.Core.Configuration;

namespace Trading_Engine_Server.Core
{
    sealed class Trading_Engine_Server : BackgroundService, ITrading_Engine_Server
    {
        private readonly ILogger<Trading_Engine_Server> _logger;
        private readonly Trading_Engine_Server_Configuration _tradingEngineServerConfig;
        public Trading_Engine_Server(ILogger<Trading_Engine_Server> logger,
            IOptions<Trading_Engine_Server_Configuration> config)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _tradingEngineServerConfig = config.Value ?? throw new ArgumentNullException(nameof(config));
        }

        public Task Run(CancellationToken token) => ExecuteAsync(token);

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation($"Started{nameof(Trading_Engine_Server)}");
            while (!stoppingToken.IsCancellationRequested)
            {

            }
            _logger.LogInformation($"Stopped{nameof(Trading_Engine_Server)}");
            return Task.CompletedTask;
        }
    }
}
