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
            this.RBtnMove = new System.Windows.Forms.RadioButton();
            this.RBtnCopy = new System.Windows.Forms.RadioButton();
            this.BtnClearConsole = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CB_Day = new System.Windows.Forms.CheckBox();
            this.CB_Month = new System.Windows.Forms.CheckBox();
            this.CB_Yeay = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.GBoxFrom.SuspendLayout();
            this.GBoxTo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.TxtConsole.Location = new System.Drawing.Point(12, 216);
            this.TxtConsole.Multiline = true;
            this.TxtConsole.Name = "TxtConsole";
            this.TxtConsole.ReadOnly = true;
            this.TxtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtConsole.Size = new System.Drawing.Size(776, 291);
            this.TxtConsole.TabIndex = 4;
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(12, 187);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(621, 23);
            this.BtnRun.TabIndex = 5;
            this.BtnRun.Text = "Organize";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // RBtnMove
            // 
            this.RBtnMove.AutoSize = true;
            this.RBtnMove.Location = new System.Drawing.Point(62, 19);
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
            this.RBtnCopy.Location = new System.Drawing.Point(7, 19);
            this.RBtnCopy.Name = "RBtnCopy";
            this.RBtnCopy.Size = new System.Drawing.Size(49, 17);
            this.RBtnCopy.TabIndex = 0;
            this.RBtnCopy.TabStop = true;
            this.RBtnCopy.Text = "Copy";
            this.RBtnCopy.UseVisualStyleBackColor = true;
            // 
            // BtnClearConsole
            // 
            this.BtnClearConsole.Location = new System.Drawing.Point(639, 187);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBtnCopy);
            this.groupBox1.Controls.Add(this.RBtnMove);
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CB_Day);
            this.groupBox2.Controls.Add(this.CB_Month);
            this.groupBox2.Controls.Add(this.CB_Yeay);
            this.groupBox2.Location = new System.Drawing.Point(390, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 45);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hierarchy";
            // 
            // CB_Day
            // 
            this.CB_Day.AutoSize = true;
            this.CB_Day.Location = new System.Drawing.Point(179, 19);
            this.CB_Day.Name = "CB_Day";
            this.CB_Day.Size = new System.Drawing.Size(45, 17);
            this.CB_Day.TabIndex = 2;
            this.CB_Day.Text = "Day";
            this.CB_Day.UseVisualStyleBackColor = true;
            this.CB_Day.CheckedChanged += new System.EventHandler(this.CB_Day_CheckedChanged);
            // 
            // CB_Month
            // 
            this.CB_Month.AutoSize = true;
            this.CB_Month.Location = new System.Drawing.Point(93, 19);
            this.CB_Month.Name = "CB_Month";
            this.CB_Month.Size = new System.Drawing.Size(56, 17);
            this.CB_Month.TabIndex = 1;
            this.CB_Month.Text = "Month";
            this.CB_Month.UseVisualStyleBackColor = true;
            this.CB_Month.CheckedChanged += new System.EventHandler(this.CB_Month_CheckedChanged);
            // 
            // CB_Yeay
            // 
            this.CB_Yeay.AutoSize = true;
            this.CB_Yeay.Location = new System.Drawing.Point(7, 19);
            this.CB_Yeay.Name = "CB_Yeay";
            this.CB_Yeay.Size = new System.Drawing.Size(48, 17);
            this.CB_Yeay.TabIndex = 0;
            this.CB_Yeay.Text = "Year";
            this.CB_Yeay.UseVisualStyleBackColor = true;
            this.CB_Yeay.CheckedChanged += new System.EventHandler(this.CB_Yeay_CheckedChanged);
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
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BtnClearConsole);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.TxtConsole);
            this.Controls.Add(this.GBoxTo);
            this.Controls.Add(this.GBoxFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SimpleDeskOrganizer";
            this.GBoxFrom.ResumeLayout(false);
            this.GBoxFrom.PerformLayout();
            this.GBoxTo.ResumeLayout(false);
            this.GBoxTo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.RadioButton RBtnMove;
        private System.Windows.Forms.RadioButton RBtnCopy;
        private System.Windows.Forms.Button BtnClearConsole;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox CB_Day;
        private System.Windows.Forms.CheckBox CB_Month;
        private System.Windows.Forms.CheckBox CB_Yeay;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

