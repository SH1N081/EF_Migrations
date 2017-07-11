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

        private List<string> _commands
        {
            get
            {
                List<string> commands = new List<string>();

                switch (Action)
                {
                    case 0:
                        commands.Clear();
                        return commands;
                    case 1:
                        commands.Clear();
                        string r = "dotnet restore";
                        commands.Add(r);
                        return commands;
                    case 2:
                        commands.Clear();
                        string m = "dotnet ef migrations add " + MigrationName;
                        commands.Add(m);
                        return commands;
                    case 3:
                        commands.Clear();
                        string rm1 = "dotnet restore";
                        string rm2 = "dotnet ef migrations add " + MigrationName;
                        commands.Add(rm1);
                        commands.Add(rm2);
                        return commands;
                    case 4:
                        commands.Clear();
                        string ru1 = "dotnet restore";
                        string ru2 = "dotnet ef database update";
                        commands.Add(ru1);
                        commands.Add(ru2);
                        return commands;
                    case 5:
                        commands.Clear();
                        string rmu1 = "dotnet restore";
                        string rmu2 = "dotnet ef migrations add " + MigrationName;
                        string rmu3 = "dotnet ef database update";
                        commands.Add(rmu1);
                        commands.Add(rmu2);
                        commands.Add(rmu3);
                        return commands;
                    case 6:
                        commands.Clear();
                        string mu1 = "dotnet ef migrations add " + MigrationName;
                        string mu2 = "dotnet ef database update";
                        commands.Add(mu1);
                        commands.Add(mu2);
                        return commands;
                    case 7:
                        commands.Clear();
                        string u = "dotnet ef database update";
                        commands.Add(u);
                        return commands;
                    default:
                        commands.Clear();
                        return commands;
                }
            }
        }

        public enum actions
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

        public List<Process> createProcessList()
        {
            List<string> commands = _commands;
            List<Process> pList = new List<Process>();
            foreach (string c in commands)
            {
                Process p = new Process();
                p.StartInfo = new ProcessStartInfo()
                {
                    RedirectStandardOutput = true,
                    RedirectStandardInput = true,
                    RedirectStandardError = true,
                    FileName = "cmd.exe",
                    WorkingDirectory = ProjectPath,
                    Arguments = c
                };
                pList.Add(p);
            }
            return pList;
        }
    }
}
