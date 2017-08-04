namespace EF_Migrations
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProjectPath = new System.Windows.Forms.Label();
            this.txtProjectPath = new System.Windows.Forms.TextBox();
            this.btnProjectPath = new System.Windows.Forms.Button();
            this.lblMigrationName = new System.Windows.Forms.Label();
            this.txtMigrationName = new System.Windows.Forms.TextBox();
            this.gboxOptions = new System.Windows.Forms.GroupBox();
            this.chkUpdate = new System.Windows.Forms.CheckBox();
            this.chkRestore = new System.Windows.Forms.CheckBox();
            this.btnMainAction = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.rtxOutput = new System.Windows.Forms.RichTextBox();
            this.btnClearOutput = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gboxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProjectPath
            // 
            this.lblProjectPath.AutoSize = true;
            this.lblProjectPath.Location = new System.Drawing.Point(13, 13);
            this.lblProjectPath.Name = "lblProjectPath";
            this.lblProjectPath.Size = new System.Drawing.Size(65, 13);
            this.lblProjectPath.TabIndex = 0;
            this.lblProjectPath.Text = "Project Path";
            // 
            // txtProjectPath
            // 
            this.txtProjectPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProjectPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProjectPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProjectPath.ForeColor = System.Drawing.Color.White;
            this.txtProjectPath.Location = new System.Drawing.Point(13, 30);
            this.txtProjectPath.Name = "txtProjectPath";
            this.txtProjectPath.Size = new System.Drawing.Size(365, 21);
            this.txtProjectPath.TabIndex = 1;
            this.txtProjectPath.TextChanged += new System.EventHandler(this.ProjectPath_TextChanged);
            // 
            // btnProjectPath
            // 
            this.btnProjectPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProjectPath.ForeColor = System.Drawing.Color.Black;
            this.btnProjectPath.Location = new System.Drawing.Point(385, 30);
            this.btnProjectPath.Name = "btnProjectPath";
            this.btnProjectPath.Size = new System.Drawing.Size(75, 21);
            this.btnProjectPath.TabIndex = 2;
            this.btnProjectPath.Text = "Browse...";
            this.btnProjectPath.UseVisualStyleBackColor = false;
            this.btnProjectPath.Click += new System.EventHandler(this.ProjectPathButton_Click);
            // 
            // lblMigrationName
            // 
            this.lblMigrationName.AutoSize = true;
            this.lblMigrationName.Location = new System.Drawing.Point(13, 75);
            this.lblMigrationName.Name = "lblMigrationName";
            this.lblMigrationName.Size = new System.Drawing.Size(82, 13);
            this.lblMigrationName.TabIndex = 3;
            this.lblMigrationName.Text = "Migration Name";
            // 
            // txtMigrationName
            // 
            this.txtMigrationName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMigrationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMigrationName.Enabled = false;
            this.txtMigrationName.ForeColor = System.Drawing.Color.White;
            this.txtMigrationName.Location = new System.Drawing.Point(13, 92);
            this.txtMigrationName.Name = "txtMigrationName";
            this.txtMigrationName.Size = new System.Drawing.Size(365, 21);
            this.txtMigrationName.TabIndex = 4;
            this.txtMigrationName.TextChanged += new System.EventHandler(this.MigrationName_TextChanged);
            // 
            // gboxOptions
            // 
            this.gboxOptions.Controls.Add(this.chkUpdate);
            this.gboxOptions.Controls.Add(this.chkRestore);
            this.gboxOptions.ForeColor = System.Drawing.Color.White;
            this.gboxOptions.Location = new System.Drawing.Point(13, 120);
            this.gboxOptions.Name = "gboxOptions";
            this.gboxOptions.Size = new System.Drawing.Size(447, 50);
            this.gboxOptions.TabIndex = 5;
            this.gboxOptions.TabStop = false;
            this.gboxOptions.Text = "Other actions";
            // 
            // chkUpdate
            // 
            this.chkUpdate.AutoSize = true;
            this.chkUpdate.Enabled = false;
            this.chkUpdate.Location = new System.Drawing.Point(164, 21);
            this.chkUpdate.Name = "chkUpdate";
            this.chkUpdate.Size = new System.Drawing.Size(109, 17);
            this.chkUpdate.TabIndex = 1;
            this.chkUpdate.Text = "Update Database";
            this.chkUpdate.UseVisualStyleBackColor = true;
            this.chkUpdate.CheckedChanged += new System.EventHandler(this.Update_CheckedChanged);
            // 
            // chkRestore
            // 
            this.chkRestore.AutoSize = true;
            this.chkRestore.Enabled = false;
            this.chkRestore.Location = new System.Drawing.Point(7, 21);
            this.chkRestore.Name = "chkRestore";
            this.chkRestore.Size = new System.Drawing.Size(132, 17);
            this.chkRestore.TabIndex = 0;
            this.chkRestore.Text = "Restore dependencies";
            this.chkRestore.UseVisualStyleBackColor = true;
            this.chkRestore.CheckedChanged += new System.EventHandler(this.Restore_CheckedChanged);
            // 
            // btnMainAction
            // 
            this.btnMainAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMainAction.Enabled = false;
            this.btnMainAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMainAction.Location = new System.Drawing.Point(97, 176);
            this.btnMainAction.Name = "btnMainAction";
            this.btnMainAction.Size = new System.Drawing.Size(363, 23);
            this.btnMainAction.TabIndex = 6;
            this.btnMainAction.UseVisualStyleBackColor = false;
            this.btnMainAction.Click += new System.EventHandler(this.MainActionButton_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Enabled = false;
            this.btnClearAll.ForeColor = System.Drawing.Color.Black;
            this.btnClearAll.Location = new System.Drawing.Point(12, 176);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(82, 23);
            this.btnClearAll.TabIndex = 7;
            this.btnClearAll.Text = "Clear all fields";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // rtxOutput
            // 
            this.rtxOutput.BackColor = System.Drawing.Color.Black;
            this.rtxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rtxOutput.Location = new System.Drawing.Point(13, 235);
            this.rtxOutput.Name = "rtxOutput";
            this.rtxOutput.ReadOnly = true;
            this.rtxOutput.Size = new System.Drawing.Size(447, 337);
            this.rtxOutput.TabIndex = 8;
            this.rtxOutput.Text = "Console output >>";
            this.rtxOutput.TextChanged += new System.EventHandler(this.Output_TextChanged);
            // 
            // btnClearOutput
            // 
            this.btnClearOutput.Enabled = false;
            this.btnClearOutput.ForeColor = System.Drawing.Color.Black;
            this.btnClearOutput.Location = new System.Drawing.Point(12, 206);
            this.btnClearOutput.Name = "btnClearOutput";
            this.btnClearOutput.Size = new System.Drawing.Size(82, 23);
            this.btnClearOutput.TabIndex = 9;
            this.btnClearOutput.Text = "Clear Output";
            this.btnClearOutput.UseVisualStyleBackColor = true;
            this.btnClearOutput.Click += new System.EventHandler(this.ClearOutputButton_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.ForeColor = System.Drawing.Color.Black;
            this.btnHelp.Location = new System.Drawing.Point(437, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 23);
            this.btnHelp.TabIndex = 10;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRemove.Enabled = false;
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(243, 206);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(217, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove latest migration";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.RemoveMigration_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(472, 584);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClearOutput);
            this.Controls.Add(this.rtxOutput);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnMainAction);
            this.Controls.Add(this.gboxOptions);
            this.Controls.Add(this.txtMigrationName);
            this.Controls.Add(this.lblMigrationName);
            this.Controls.Add(this.btnProjectPath);
            this.Controls.Add(this.txtProjectPath);
            this.Controls.Add(this.lblProjectPath);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = ".NET Entity Framework Migrations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxOptions.ResumeLayout(false);
            this.gboxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectPath;
        private System.Windows.Forms.TextBox txtProjectPath;
        private System.Windows.Forms.Button btnProjectPath;
        private System.Windows.Forms.Label lblMigrationName;
        private System.Windows.Forms.TextBox txtMigrationName;
        private System.Windows.Forms.GroupBox gboxOptions;
        private System.Windows.Forms.CheckBox chkUpdate;
        private System.Windows.Forms.CheckBox chkRestore;
        private System.Windows.Forms.Button btnMainAction;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.RichTextBox rtxOutput;
        private System.Windows.Forms.Button btnClearOutput;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnRemove;
    }
}

