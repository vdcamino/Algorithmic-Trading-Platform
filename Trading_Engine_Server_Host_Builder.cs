using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trading_Engine_Server.Core.Configuration;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Trading_Engine_Server.Core
{
    public sealed class Trading_Engine_Server_Host_Builder
    {
        public static IHost BuildTradingEngineServer()
            => Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                // Start with configuration
                services.AddOptions();
                services.Configure<Trading_Engine_Server_Configuration>(context.Configuration.GetSection(nameof(Trading_Engine_Server_Configuration)));

                // Add singleton objects
                services.AddSingleton<ITrading_Engine_Server, Trading_Engine_Server>();

                // Add hosted service
                services.AddHostedService<Trading_Engine_Server>();
            }
            ).Build(); 
    }
}
