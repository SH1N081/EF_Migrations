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

        //CREATE COMMAND
        public Command createCommand(Transaction t)
        {
            Command c = new Command();
            return c;
        }

        //CREATE COMMAND LIST
        public List<Command> createCommandList(Transaction t)
        {
            List<Command> cList = new List<Command>();
            return cList;
        }
    }
}
