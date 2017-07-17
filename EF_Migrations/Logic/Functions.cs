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
        public enum Actions
        {
            None,
            Restore,
            Migrate,
            RestoreUpdate,
            RestoreMigrate,
            RestoreMigrateUpdate,
            MigrateUpdate,
            Update
        }

        //CREATE COMMAND LIST
        public List<Command> CreateCommandList(Transaction t)
        {
            List<Command> cList = new List<Command>();
            Command restore = new Command()
            {
                Text = "dotnet restore"
            };
            Command migrate = new Command()
            {
                Text = "dotnet ef migrations add " + t.MigrationName
            };
            Command update = new Command()
            {
                Text = "dotnet ef database update"
            };

            switch (t.Action)
            {
                case (int)Actions.None:
                    cList.Clear();
                    break;
                case (int)Actions.Restore:
                    cList.Clear();
                    cList.Add(restore);
                    break;
                case (int)Actions.Migrate:
                    cList.Clear();
                    cList.Add(migrate);
                    break;
                case (int)Actions.Update:
                    cList.Clear();
                    cList.Add(update);
                    break;
                case (int)Actions.RestoreMigrate:
                    cList.Clear();
                    cList.Add(restore);
                    cList.Add(migrate);
                    break;
                case (int)Actions.RestoreUpdate:
                    cList.Clear();
                    cList.Add(restore);
                    cList.Add(update);
                    break;
                case (int)Actions.RestoreMigrateUpdate:
                    cList.Clear();
                    cList.Add(restore);
                    cList.Add(migrate);
                    cList.Add(update);
                    break;
                case (int)Actions.MigrateUpdate:
                    cList.Clear();
                    cList.Add(migrate);
                    cList.Add(update);
                    break;
                default:
                    cList.Clear();
                    break;
            }
            return cList;
        }

        //CREATE PROCESS
        public Process CreateProcess(string path, Command command)
        {
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                RedirectStandardError = true,
                FileName = "cmd.exe",
                Domain = path,
                Arguments = command.Text
            };
            Process p = new Process()
            {
                StartInfo = psi
            };
            return p;
        }

        //CREATE PROCESS LIST
        public List<Process> CreateProcessList(string path, List<Command> commands)
        {
            List<Process> pList = new List<Process>();

            foreach (Command c in commands)
            {
                Process p = CreateProcess(path, c);
                pList.Add(p);
            }
            return pList;
        }

    }
}
