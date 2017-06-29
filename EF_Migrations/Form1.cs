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
            Functions f = new Functions();
            Migration m = new Migration()
            {

            };
        }

        public void doMigration()
        {
            Functions f = new Functions();
            Migration m = new Migration()
            {

            };
        }

        public void doUpdate()
        {
            Functions f = new Functions();
            Migration m = new Migration()
            {

            };
        }

        public void clearAll()
        {
            tbxProjectPath.Text = "";
            tboxMigrationName.Text = "";
            chboxRestore.Checked = false;
            chboxUpdate.Checked = false;
        }

        public void checkButtonStatus()
        {
            if (tbxProjectPath.Text == "")
            {
                btnMainAction.Enabled = false;
                btnMainAction.Text = "";
            }
            else if (tbxProjectPath.Text != "")
            {
                if (tboxMigrationName.Text == "")
                {
                    if (!chboxRestore.Checked && !chboxUpdate.Checked)
                    {
                        btnMainAction.Enabled = false;
                        btnMainAction.Text = "";
                    }
                }
            }
        }

        #endregion FUNCTIONS

        #region EVENTS

        void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.Write(e.Data);
        }

        private void tbxProjectPath_TextChanged(object sender, EventArgs e)
        {
            if (tbxProjectPath.Text == "")
            {
                tboxMigrationName.Enabled = false;
                chboxRestore.Enabled = false;
                chboxUpdate.Enabled = false;
            }
            else if (tbxProjectPath.Text != "")
            {
                tboxMigrationName.Enabled = true;
                chboxRestore.Enabled = true;
                chboxUpdate.Enabled = true;
            }
        }

        private void tboxMigrationName_TextChanged(object sender, EventArgs e)
        {

        }

        private void chboxRestore_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chboxUpdate_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnProjectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select project folder";
            fbd.ShowNewFolderButton = false;
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tbxProjectPath.Text = fbd.SelectedPath;
            }
        }

        #endregion EVENTS

    }
}
