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
        public int Action { get; set; }
        public string Command { get; set; }

        enum actions
        {
            None,
            Restore,
            Migrate,
            RestoreMigrate,
            RestoreUpdate,
            RestoreMigrateUpdate,
            MigrateUpdate,
            Update
        };

        //Add definitions for the different commands

        public Process createProcess()
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo()
            {

            };
            return p;
        }
    }
}
