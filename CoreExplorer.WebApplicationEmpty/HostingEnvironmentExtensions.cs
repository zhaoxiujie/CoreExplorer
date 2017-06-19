using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreExplorer.WebApplicationEmpty
{
    public static class HostingEnvironmentExtensions
    {
        public static bool IsQualityAssurance(this IHostingEnvironment hostEnv)
        {
            return hostEnv.EnvironmentName.Equals("QualityAssurance");

        }
    }
}
