using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACM.Common
{
    class LogginServices
    {
        public static void WriteToLog(List<ILoggable> changedItems)
        {
            foreach (var item in changedItems)
            {
              
                Console.WriteLine(item.Log());
            }
        }
    }
}
