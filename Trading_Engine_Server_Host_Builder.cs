using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;

namespace Trading_Engine_Server.Core
{
    public sealed class Trading_Engine_Server_Host_Builder
    {
        public static IHost BuildTradingEngineServer()
            => Host.CreateDefaultBuilder().ConfigureServices((ContextBoundObject, services) =>
            {
                // Start with configuration
            }
            ).Build(); 
    }
}
