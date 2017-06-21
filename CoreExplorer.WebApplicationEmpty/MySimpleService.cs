using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreExplorer.WebApplicationEmpty
{
    public class MySimpleService
    {
        private readonly Configuration _config;
        private readonly ILogger _log;
        public MySimpleService(Configuration configuration,ILogger<MySimpleService> log)
        {
            this._config = configuration;
            this._log = log;
        }


        public void DoSomething()
        {
            _log.LogInformation("MySimpleService DoSomething...");
        }
    }
}
