using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trading_Engine_Server.Core
{
    interface ITrading_Engine_Server
    {
        Task Run(CancellationToken token);

    }
}
