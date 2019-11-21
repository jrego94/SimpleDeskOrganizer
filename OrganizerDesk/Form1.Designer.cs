namespace OrganizerDesk
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
            this.GBoxFrom = new System.Windows.Forms.GroupBox();
            this.TxtPathFrom = new System.Windows.Forms.TextBox();
            this.BtnSelectFrom = new System.Windows.Forms.Button();
            this.GBoxTo = new System.Windows.Forms.GroupBox();
            this.TxtPathTo = new System.Windows.Forms.TextBox();
            this.BtnSelectTo = new System.Windows.Forms.Button();
            this.TxtConsole = new System.Windows.Forms.TextBox();
            this.BtnRun = new System.Windows.Forms.Button();
            this.GBoxOpt = new System.Windows.Forms.GroupBox();
            this.RBtnMove = new System.Windows.Forms.RadioButton();
            this.RBtnCopy = new System.Windows.Forms.RadioButton();
            this.BtnClearConsole = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.GBoxFrom.SuspendLayout();
            this.GBoxTo.SuspendLayout();
            this.GBoxOpt.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBoxFrom
            // 
            this.GBoxFrom.Controls.Add(this.TxtPathFrom);
            this.GBoxFrom.Controls.Add(this.BtnSelectFrom);
            this.GBoxFrom.Location = new System.Drawing.Point(12, 12);
            this.GBoxFrom.Name = "GBoxFrom";
            this.GBoxFrom.Size = new System.Drawing.Size(776, 56);
            this.GBoxFrom.TabIndex = 2;
            this.GBoxFrom.TabStop = false;
            this.GBoxFrom.Text = "From";
            // 
            // TxtPathFrom
            // 
            this.TxtPathFrom.Enabled = false;
            this.TxtPathFrom.Location = new System.Drawing.Point(114, 22);
            this.TxtPathFrom.Name = "TxtPathFrom";
            this.TxtPathFrom.Size = new System.Drawing.Size(656, 20);
            this.TxtPathFrom.TabIndex = 1;
            // 
            // BtnSelectFrom
            // 
            this.BtnSelectFrom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSelectFrom.Location = new System.Drawing.Point(7, 20);
            this.BtnSelectFrom.Name = "BtnSelectFrom";
            this.BtnSelectFrom.Size = new System.Drawing.Size(101, 23);
            this.BtnSelectFrom.TabIndex = 0;
            this.BtnSelectFrom.Text = "Select Folder";
            this.BtnSelectFrom.UseVisualStyleBackColor = true;
            this.BtnSelectFrom.Click += new System.EventHandler(this.BtnSelectFrom_Click);
            // 
            // GBoxTo
            // 
            this.GBoxTo.Controls.Add(this.TxtPathTo);
            this.GBoxTo.Controls.Add(this.BtnSelectTo);
            this.GBoxTo.Location = new System.Drawing.Point(12, 74);
            this.GBoxTo.Name = "GBoxTo";
            this.GBoxTo.Size = new System.Drawing.Size(776, 56);
            this.GBoxTo.TabIndex = 3;
            this.GBoxTo.TabStop = false;
            this.GBoxTo.Text = "To";
            // 
            // TxtPathTo
            // 
            this.TxtPathTo.Enabled = false;
            this.TxtPathTo.Location = new System.Drawing.Point(114, 22);
            this.TxtPathTo.Name = "TxtPathTo";
            this.TxtPathTo.Size = new System.Drawing.Size(656, 20);
            this.TxtPathTo.TabIndex = 1;
            // 
            // BtnSelectTo
            // 
            this.BtnSelectTo.Location = new System.Drawing.Point(7, 20);
            this.BtnSelectTo.Name = "BtnSelectTo";
            this.BtnSelectTo.Size = new System.Drawing.Size(101, 23);
            this.BtnSelectTo.TabIndex = 0;
            this.BtnSelectTo.Text = "Select Folder";
            this.BtnSelectTo.UseVisualStyleBackColor = true;
            this.BtnSelectTo.Click += new System.EventHandler(this.BtnSelectTo_Click);
            // 
            // TxtConsole
            // 
            this.TxtConsole.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConsole.HideSelection = false;
            this.TxtConsole.Location = new System.Drawing.Point(12, 227);
            this.TxtConsole.Multiline = true;
            this.TxtConsole.Name = "TxtConsole";
            this.TxtConsole.ReadOnly = true;
            this.TxtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtConsole.Size = new System.Drawing.Size(776, 280);
            this.TxtConsole.TabIndex = 4;
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(12, 198);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(621, 23);
            this.BtnRun.TabIndex = 5;
            this.BtnRun.Text = "Organize";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // GBoxOpt
            // 
            this.GBoxOpt.Controls.Add(this.RBtnMove);
            this.GBoxOpt.Controls.Add(this.RBtnCopy);
            this.GBoxOpt.Location = new System.Drawing.Point(13, 137);
            this.GBoxOpt.Name = "GBoxOpt";
            this.GBoxOpt.Size = new System.Drawing.Size(775, 55);
            this.GBoxOpt.TabIndex = 6;
            this.GBoxOpt.TabStop = false;
            this.GBoxOpt.Text = "Options";
            // 
            // RBtnMove
            // 
            this.RBtnMove.AutoSize = true;
            this.RBtnMove.Location = new System.Drawing.Point(61, 19);
            this.RBtnMove.Name = "RBtnMove";
            this.RBtnMove.Size = new System.Drawing.Size(52, 17);
            this.RBtnMove.TabIndex = 1;
            this.RBtnMove.Text = "Move";
            this.RBtnMove.UseVisualStyleBackColor = true;
            // 
            // RBtnCopy
            // 
            this.RBtnCopy.AutoSize = true;
            this.RBtnCopy.Checked = true;
            this.RBtnCopy.Location = new System.Drawing.Point(6, 19);
            this.RBtnCopy.Name = "RBtnCopy";
            this.RBtnCopy.Size = new System.Drawing.Size(49, 17);
            this.RBtnCopy.TabIndex = 0;
            this.RBtnCopy.TabStop = true;
            this.RBtnCopy.Text = "Copy";
            this.RBtnCopy.UseVisualStyleBackColor = true;
            // 
            // BtnClearConsole
            // 
            this.BtnClearConsole.Location = new System.Drawing.Point(639, 198);
            this.BtnClearConsole.Name = "BtnClearConsole";
            this.BtnClearConsole.Size = new System.Drawing.Size(149, 23);
            this.BtnClearConsole.TabIndex = 7;
            this.BtnClearConsole.Text = "Clear Console";
            this.BtnClearConsole.UseVisualStyleBackColor = true;
            this.BtnClearConsole.Click += new System.EventHandler(this.BtnClearConsole_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 513);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 19);
            this.progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BtnClearConsole);
            this.Controls.Add(this.GBoxOpt);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.TxtConsole);
            this.Controls.Add(this.GBoxTo);
            this.Controls.Add(this.GBoxFrom);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.GBoxFrom.ResumeLayout(false);
            this.GBoxFrom.PerformLayout();
            this.GBoxTo.ResumeLayout(false);
            this.GBoxTo.PerformLayout();
            this.GBoxOpt.ResumeLayout(false);
            this.GBoxOpt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GBoxFrom;
        private System.Windows.Forms.TextBox TxtPathFrom;
        private System.Windows.Forms.Button BtnSelectFrom;
        private System.Windows.Forms.GroupBox GBoxTo;
        private System.Windows.Forms.TextBox TxtPathTo;
        private System.Windows.Forms.Button BtnSelectTo;
        private System.Windows.Forms.TextBox TxtConsole;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.GroupBox GBoxOpt;
        private System.Windows.Forms.RadioButton RBtnMove;
        private System.Windows.Forms.RadioButton RBtnCopy;
        private System.Windows.Forms.Button BtnClearConsole;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

