using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.Tools
{
    /// <summary>
    /// Check if the necessay process is running
    /// </summary>
    class AppHelper
    {
        public static bool checkEveryThing()
        {
            var ps=Process.GetProcessesByName("Everything");
            foreach (var item in ps)
            {
                if (item.HasExited == false)
                    return true;
            }
           
                return false;
        }
    }
}
