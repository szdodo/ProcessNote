namespace ProcessNote
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MemLabel2 = new System.Windows.Forms.Label();
            this.MemLabel1 = new System.Windows.Forms.Label();
            this.EndButton = new System.Windows.Forms.Button();
            this.ProcessListBox = new System.Windows.Forms.ListBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.CPULabel1 = new System.Windows.Forms.Label();
            this.CPULabel2 = new System.Windows.Forms.Label();
            this.StartTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Controls.Add(this.StartTextBox);
            this.groupBox1.Controls.Add(this.CPULabel2);
            this.groupBox1.Controls.Add(this.CPULabel1);
            this.groupBox1.Controls.Add(this.MemLabel2);
            this.groupBox1.Controls.Add(this.MemLabel1);
            this.groupBox1.Controls.Add(this.EndButton);
            this.groupBox1.Controls.Add(this.ProcessListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Running Processes";
            // 
            // MemLabel2
            // 
            this.MemLabel2.AutoSize = true;
            this.MemLabel2.Location = new System.Drawing.Point(287, 19);
            this.MemLabel2.Name = "MemLabel2";
            this.MemLabel2.Size = new System.Drawing.Size(13, 13);
            this.MemLabel2.TabIndex = 4;
            this.MemLabel2.Text = "0";
            // 
            // MemLabel1
            // 
            this.MemLabel1.AutoSize = true;
            this.MemLabel1.Location = new System.Drawing.Point(200, 19);
            this.MemLabel1.Name = "MemLabel1";
            this.MemLabel1.Size = new System.Drawing.Size(81, 13);
            this.MemLabel1.TabIndex = 3;
            this.MemLabel1.Text = "Memory Usage:";
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(16, 19);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(95, 23);
            this.EndButton.TabIndex = 2;
            this.EndButton.Text = "End Proccess";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // ProcessListBox
            // 
            this.ProcessListBox.FormattingEnabled = true;
            this.ProcessListBox.Location = new System.Drawing.Point(16, 73);
            this.ProcessListBox.Name = "ProcessListBox";
            this.ProcessListBox.Size = new System.Drawing.Size(618, 225);
            this.ProcessListBox.TabIndex = 1;
            this.ProcessListBox.SelectedIndexChanged += new System.EventHandler(this.ProcessListBox_SelectedIndexChanged);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // CPULabel1
            // 
            this.CPULabel1.AutoSize = true;
            this.CPULabel1.Location = new System.Drawing.Point(200, 45);
            this.CPULabel1.Name = "CPULabel1";
            this.CPULabel1.Size = new System.Drawing.Size(66, 13);
            this.CPULabel1.TabIndex = 5;
            this.CPULabel1.Text = "CPU Usage:";
            // 
            // CPULabel2
            // 
            this.CPULabel2.AutoSize = true;
            this.CPULabel2.Location = new System.Drawing.Point(287, 45);
            this.CPULabel2.Name = "CPULabel2";
            this.CPULabel2.Size = new System.Drawing.Size(13, 13);
            this.CPULabel2.TabIndex = 6;
            this.CPULabel2.Text = "0";
            // 
            // StartTextBox
            // 
            this.StartTextBox.Location = new System.Drawing.Point(415, 42);
            this.StartTextBox.Name = "StartTextBox";
            this.StartTextBox.Size = new System.Drawing.Size(100, 20);
            this.StartTextBox.TabIndex = 7;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(538, 40);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(86, 23);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "Start Process";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 322);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ProcessListBox;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Label MemLabel1;
        private System.Windows.Forms.Label MemLabel2;
        private System.Windows.Forms.Label CPULabel1;
        private System.Windows.Forms.Label CPULabel2;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox StartTextBox;
    }
}

