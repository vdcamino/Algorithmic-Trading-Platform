using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trading_Engine_Server.Core.Configuration
{
    class Trading_Engine_Server_Configuration
    {            
        public Trading_Engine_Services_Settings Trading_Engine_Services_Settings { get; set; }
    }

    class Trading_Engine_Services_Settings
    {
        public int Port {get; set; }
    }
}
