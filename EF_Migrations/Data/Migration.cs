using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EF_Migrations.Data
{
    class Migration
    {
        public string ProjectPath { get; set; }
        public string MigrationName { get; set; }
        public ProcessStartInfo Command { get; set; }
    }
}
