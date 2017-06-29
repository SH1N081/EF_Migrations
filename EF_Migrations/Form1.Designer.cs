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
            this.tbxProjectPath = new System.Windows.Forms.TextBox();
            this.btnProjectPath = new System.Windows.Forms.Button();
            this.lblMigrationName = new System.Windows.Forms.Label();
            this.tboxMigrationName = new System.Windows.Forms.TextBox();
            this.gboxOptions = new System.Windows.Forms.GroupBox();
            this.chboxUpdate = new System.Windows.Forms.CheckBox();
            this.chboxRestore = new System.Windows.Forms.CheckBox();
            this.btnMainAction = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.rtboxOutput = new System.Windows.Forms.RichTextBox();
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
            // tbxProjectPath
            // 
            this.tbxProjectPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxProjectPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxProjectPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxProjectPath.ForeColor = System.Drawing.Color.White;
            this.tbxProjectPath.Location = new System.Drawing.Point(13, 30);
            this.tbxProjectPath.Name = "tbxProjectPath";
            this.tbxProjectPath.Size = new System.Drawing.Size(365, 21);
            this.tbxProjectPath.TabIndex = 1;
            this.tbxProjectPath.TextChanged += new System.EventHandler(this.tbxProjectPath_TextChanged);
            // 
            // btnProjectPath
            // 
            this.btnProjectPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProjectPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProjectPath.Location = new System.Drawing.Point(385, 30);
            this.btnProjectPath.Name = "btnProjectPath";
            this.btnProjectPath.Size = new System.Drawing.Size(75, 21);
            this.btnProjectPath.TabIndex = 2;
            this.btnProjectPath.Text = "Browse...";
            this.btnProjectPath.UseVisualStyleBackColor = false;
            this.btnProjectPath.Click += new System.EventHandler(this.btnProjectPath_Click);
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
            // tboxMigrationName
            // 
            this.tboxMigrationName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tboxMigrationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxMigrationName.Enabled = false;
            this.tboxMigrationName.ForeColor = System.Drawing.Color.White;
            this.tboxMigrationName.Location = new System.Drawing.Point(13, 92);
            this.tboxMigrationName.Name = "tboxMigrationName";
            this.tboxMigrationName.Size = new System.Drawing.Size(365, 21);
            this.tboxMigrationName.TabIndex = 4;
            this.tboxMigrationName.TextChanged += new System.EventHandler(this.tboxMigrationName_TextChanged);
            // 
            // gboxOptions
            // 
            this.gboxOptions.Controls.Add(this.chboxUpdate);
            this.gboxOptions.Controls.Add(this.chboxRestore);
            this.gboxOptions.ForeColor = System.Drawing.Color.White;
            this.gboxOptions.Location = new System.Drawing.Point(13, 120);
            this.gboxOptions.Name = "gboxOptions";
            this.gboxOptions.Size = new System.Drawing.Size(447, 50);
            this.gboxOptions.TabIndex = 5;
            this.gboxOptions.TabStop = false;
            this.gboxOptions.Text = "Other actions";
            // 
            // chboxUpdate
            // 
            this.chboxUpdate.AutoSize = true;
            this.chboxUpdate.Enabled = false;
            this.chboxUpdate.Location = new System.Drawing.Point(164, 21);
            this.chboxUpdate.Name = "chboxUpdate";
            this.chboxUpdate.Size = new System.Drawing.Size(109, 17);
            this.chboxUpdate.TabIndex = 1;
            this.chboxUpdate.Text = "Update Database";
            this.chboxUpdate.UseVisualStyleBackColor = true;
            this.chboxUpdate.CheckedChanged += new System.EventHandler(this.chboxUpdate_CheckedChanged);
            // 
            // chboxRestore
            // 
            this.chboxRestore.AutoSize = true;
            this.chboxRestore.Enabled = false;
            this.chboxRestore.Location = new System.Drawing.Point(7, 21);
            this.chboxRestore.Name = "chboxRestore";
            this.chboxRestore.Size = new System.Drawing.Size(132, 17);
            this.chboxRestore.TabIndex = 0;
            this.chboxRestore.Text = "Restore dependencies";
            this.chboxRestore.UseVisualStyleBackColor = true;
            this.chboxRestore.CheckedChanged += new System.EventHandler(this.chboxRestore_CheckedChanged);
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
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // rtboxOutput
            // 
            this.rtboxOutput.BackColor = System.Drawing.Color.Black;
            this.rtboxOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtboxOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rtboxOutput.Location = new System.Drawing.Point(13, 235);
            this.rtboxOutput.Name = "rtboxOutput";
            this.rtboxOutput.Size = new System.Drawing.Size(447, 337);
            this.rtboxOutput.TabIndex = 8;
            this.rtboxOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(472, 584);
            this.Controls.Add(this.rtboxOutput);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnMainAction);
            this.Controls.Add(this.gboxOptions);
            this.Controls.Add(this.tboxMigrationName);
            this.Controls.Add(this.lblMigrationName);
            this.Controls.Add(this.btnProjectPath);
            this.Controls.Add(this.tbxProjectPath);
            this.Controls.Add(this.lblProjectPath);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = ".NET Entity Framework Migrations";
            this.gboxOptions.ResumeLayout(false);
            this.gboxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectPath;
        private System.Windows.Forms.TextBox tbxProjectPath;
        private System.Windows.Forms.Button btnProjectPath;
        private System.Windows.Forms.Label lblMigrationName;
        private System.Windows.Forms.TextBox tboxMigrationName;
        private System.Windows.Forms.GroupBox gboxOptions;
        private System.Windows.Forms.CheckBox chboxUpdate;
        private System.Windows.Forms.CheckBox chboxRestore;
        private System.Windows.Forms.Button btnMainAction;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.RichTextBox rtboxOutput;
    }
}

