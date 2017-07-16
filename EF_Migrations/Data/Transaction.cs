using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EF_Migrations.Data
{
    class Transaction
    {
        public string ProjectPath { get; set; }
        public string MigrationName { get; set; }
        public int Action { get; set; }
        public List<Command> Commands { get; set; }
        public List<Process> processList { get; set; }
    }
}
