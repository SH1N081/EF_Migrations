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
        public List<Command> createCommandList(Transaction t)
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
        public Process createProcess(Command command)
        {
            Process p = new Process();
            return p;
        }

        //CREATE PROCESS LIST
        public List<Process> createProcessList(List<Command> commands)
        {
            List<Process> pList = new List<Process>();
            return pList;
        }

    }
}
