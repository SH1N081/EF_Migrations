﻿using System;
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
        Transaction t = new Transaction();

        public Form1()
        {
            InitializeComponent();
        }

        #region METHODS

        public void ClearAll()
        {
            txtProjectPath.Text = "";
            txtMigrationName.Text = "";
            chkRestore.Checked = false;
            chkUpdate.Checked = false;
            rtxOutput.Text = "Console output >>";
            t = new Transaction();
        }

        public void CheckMainAction()
        {
            if (string.IsNullOrEmpty(txtMigrationName.Text))
            {
                if (!chkRestore.Checked && !chkUpdate.Checked)
                {
                    t.Action = (int)Methods.Actions.None;
                    btnMainAction.Enabled = false;
                    btnMainAction.Text = "";
                }
                else if (chkRestore.Checked && !chkUpdate.Checked)
                {
                    t.Action = (int)Methods.Actions.Restore;
                    btnMainAction.Enabled = true;
                    btnMainAction.Text = "Restore dependencies";
                }
                else if (!chkRestore.Checked && chkUpdate.Checked)
                {
                    t.Action = (int)Methods.Actions.Update;
                    btnMainAction.Enabled = true;
                    btnMainAction.Text = "Update EF database";
                }
                else if (chkRestore.Checked && chkUpdate.Checked)
                {
                    t.Action = (int)Methods.Actions.RestoreUpdate;
                    btnMainAction.Enabled = true;
                    btnMainAction.Text = "Restore dependencies and update EF database";
                }
            }
            else if (!string.IsNullOrEmpty(txtMigrationName.Text))
            {
                t.MigrationName = txtMigrationName.Text;

                if (!chkRestore.Checked && !chkUpdate.Checked)
                {
                    t.Action = (int)Methods.Actions.Migrate;
                    btnMainAction.Enabled = true;
                    btnMainAction.Text = "Create migration";
                }
                else if (chkRestore.Checked && !chkUpdate.Checked)
                {
                    t.Action = (int)Methods.Actions.RestoreMigrate;
                    btnMainAction.Enabled = true;
                    btnMainAction.Text = "Restore dependencies and create migration";
                }
                else if (!chkRestore.Checked && chkUpdate.Checked)
                {
                    t.Action = (int)Methods.Actions.MigrateUpdate;
                    btnMainAction.Enabled = true;
                    btnMainAction.Text = "Create migration and update EF database";
                }
                else if (chkRestore.Checked && chkUpdate.Checked)
                {
                    t.Action = (int)Methods.Actions.RestoreMigrateUpdate;
                    btnMainAction.Enabled = true;
                    btnMainAction.Text = "Restore dependencies, create migration and update EF database";
                }
            }
        }

        public void CheckClearAll()
        {
            if (string.IsNullOrEmpty(txtProjectPath.Text) && string.IsNullOrEmpty(txtMigrationName.Text) && !chkRestore.Checked && !chkUpdate.Checked)
            {
                btnClearAll.Enabled = false;
            }
            else if (!string.IsNullOrEmpty(txtProjectPath.Text) || !string.IsNullOrEmpty(txtMigrationName.Text) || chkRestore.Checked || chkUpdate.Checked)
            {
                btnClearAll.Enabled = true;
            }
        }

        public void CheckClearOutput()
        {
            if (rtxOutput.Text != "Console output >>")
            {
                btnClearOutput.Enabled = true;
            }
            else if (rtxOutput.Text == "Console output >>")
            {
                btnClearOutput.Enabled = false;
            }
        }

        public void ShowHelp()
        {
            MessageBox.Show(
                "This is a simple application for performing .NET Entity Framework Migrations.\r\n" +
                "3 actions affiliated with database migration can be performed in combination or separately.\r\n" +
                "All actions require a project path to be selected - either input manually or by using the browse function.\r\n" +
                "\r\n" +
                "RESTORE DEPENDENCIES\r\n" +
                "To restore dependencies, check the corresponding box and click on the button \"Restore dependencies\".\r\n" +
                "\r\n" +
                "UPDATE DATABASE\r\n" +
                "To update the database, check the corresponding box and click on the button \"Update database\".\r\n" +
                "\r\n" +
                "CREATE MIGRATION\r\n" +
                "If a migration name is entered in the text box, a migration will be created.\r\n" +
                "\r\n" +
                "COMBINATIONS\r\n" +
                "All 3 actions may be combined in any way. IMPORTANT: if a migration name is entered, a migration will always be created.\r\n" +
                "Text on the button will change to reflect the currently selected actions.\r\n" +
                "\r\n" +
                "This help file may be accessed at any time via the button \"?\" in the top right corner of the application window.",
                "Getting started",
                MessageBoxButtons.OK,
                MessageBoxIcon.None
                );
        }

        public void ExecuteCommand(Process process)
        {
            try
            {
                Process p = process;
                p.Start();
                string output = p.StandardOutput.ReadToEnd();
                rtxOutput.AppendText("\n" + output);
                p.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion METHODS

        #region EVENTS
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowHelp();
        }

        private void ProjectPath_TextChanged(object sender, EventArgs e)
        {
            CheckClearAll();
            CheckMainAction();

            if (string.IsNullOrEmpty(txtProjectPath.Text))
            {
                txtMigrationName.Enabled = false;
                chkRestore.Enabled = false;
                chkUpdate.Enabled = false;
                btnMainAction.Enabled = false;
            }
            else if (!string.IsNullOrEmpty(txtProjectPath.Text))
            {
                txtMigrationName.Enabled = true;
                chkRestore.Enabled = true;
                chkUpdate.Enabled = true;
                if (txtMigrationName.Text != "" || chkRestore.Checked || chkUpdate.Checked)
                {
                    btnMainAction.Enabled = true;
                }
                else if (txtMigrationName.Text == "" && !chkRestore.Checked && !chkUpdate.Checked)
                {
                    btnMainAction.Enabled = false;
                }
            }
        }

        private void MigrationName_TextChanged(object sender, EventArgs e)
        {
            CheckClearAll();
            CheckMainAction();
        }

        private void Restore_CheckedChanged(object sender, EventArgs e)
        {
            CheckClearAll();
            CheckMainAction();
        }

        private void Update_CheckedChanged(object sender, EventArgs e)
        {
            CheckClearAll();
            CheckMainAction();
        }

        private void ProjectPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog()
            {
                Description = "Select project folder",
                ShowNewFolderButton = false,
                RootFolder = Environment.SpecialFolder.MyComputer
            };

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtProjectPath.Text = fbd.SelectedPath;
            }
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearOutputButton_Click(object sender, EventArgs e)
        {
            rtxOutput.Clear();
            rtxOutput.Text = "Console output >>";
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {
            CheckClearOutput();
        }
        private void HelpButton_Click(object sender, EventArgs e)
        {
            ShowHelp();
        }

        // MAIN BUTTON CLICK EVENT
        private void MainActionButton_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            t.ProjectPath = txtProjectPath.Text;
            t.Commands = m.CreateCommandList(t);
            t.ProcessList = m.CreateProcessList(t.ProjectPath, t.Commands);
            List<Process> pList = t.ProcessList;
            rtxOutput.Clear();
            foreach (Process p in pList)
            {
                ExecuteCommand(p);
            }
        }

        #endregion EVENTS

    }
}
