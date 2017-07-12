using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using EF_Migrations.Data;

namespace EF_Migrations.Logic
{
    class Functions
    {
        Migration m = new Migration();

        public Process createProcess(string path, List<string> commands)
        {
            Process p = new Process();
            return p;
            
        }
    }
}
