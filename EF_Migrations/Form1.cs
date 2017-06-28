using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using EF_Migrations.Data;
using EF_Migrations.Logic;

namespace EF_Migrations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region FUNCTIONS

        public void doRestore()
        {
            Migration m = new Migration()
            {

            };
        }

        public void doMigration()
        {
            Migration m = new Migration()
            {

            };
        }

        public void doUpdate()
        {
            Migration m = new Migration()
            {

            };
        }

        #endregion FUNCTIONS

        #region EVENTS

        void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.Write(e.Data);
        }

        #endregion EVENTS
    }
}
