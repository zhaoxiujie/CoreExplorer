using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreExplorer.WebApplicationEmpty
{
    public class Clock : IClock
    {
        public DateTime GetCurrentTime()
        {
            return DateTime.Now;
        }
    }
}
