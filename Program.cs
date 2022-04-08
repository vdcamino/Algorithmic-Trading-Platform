using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Trading_Engine_Server.Core;

using var engine = Trading_Engine_Server_Host_Builder.BuildTradingEngineServer();
Trading_Engine_Server_Service_Provider.ServiceProvider = engine.Services;
{
    using var scope = Trading_Engine_Server_Service_Provider.ServiceProvider.CreateScope();
    await engine.RunAsync().ConfigureAwait(false);
}
