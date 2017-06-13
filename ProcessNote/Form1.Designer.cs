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
            this.CommentBtn = new System.Windows.Forms.Button();
            this.CommentBox = new System.Windows.Forms.TextBox();
            this.RunningLabel2 = new System.Windows.Forms.Label();
            this.RunningLabel1 = new System.Windows.Forms.Label();
            this.StartLabel2 = new System.Windows.Forms.Label();
            this.StartLabel1 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.StartTextBox = new System.Windows.Forms.TextBox();
            this.CPULabel2 = new System.Windows.Forms.Label();
            this.CPULabel1 = new System.Windows.Forms.Label();
            this.MemLabel2 = new System.Windows.Forms.Label();
            this.MemLabel1 = new System.Windows.Forms.Label();
            this.EndBtn = new System.Windows.Forms.Button();
            this.ProcessListBox = new System.Windows.Forms.ListBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.TopCheckBox = new System.Windows.Forms.CheckBox();
            this.AllCommBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AllCommBtn);
            this.groupBox1.Controls.Add(this.TopCheckBox);
            this.groupBox1.Controls.Add(this.CommentBtn);
            this.groupBox1.Controls.Add(this.CommentBox);
            this.groupBox1.Controls.Add(this.RunningLabel2);
            this.groupBox1.Controls.Add(this.RunningLabel1);
            this.groupBox1.Controls.Add(this.StartLabel2);
            this.groupBox1.Controls.Add(this.StartLabel1);
            this.groupBox1.Controls.Add(this.StartBtn);
            this.groupBox1.Controls.Add(this.StartTextBox);
            this.groupBox1.Controls.Add(this.CPULabel2);
            this.groupBox1.Controls.Add(this.CPULabel1);
            this.groupBox1.Controls.Add(this.MemLabel2);
            this.groupBox1.Controls.Add(this.MemLabel1);
            this.groupBox1.Controls.Add(this.EndBtn);
            this.groupBox1.Controls.Add(this.ProcessListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Running Processes";
            // 
            // CommentBtn
            // 
            this.CommentBtn.Location = new System.Drawing.Point(670, 16);
            this.CommentBtn.Name = "CommentBtn";
            this.CommentBtn.Size = new System.Drawing.Size(96, 23);
            this.CommentBtn.TabIndex = 14;
            this.CommentBtn.Text = "Add Comment";
            this.CommentBtn.UseVisualStyleBackColor = true;
            this.CommentBtn.Click += new System.EventHandler(this.CommentBtn_Click);
            // 
            // CommentBox
            // 
            this.CommentBox.Location = new System.Drawing.Point(494, 16);
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(145, 20);
            this.CommentBox.TabIndex = 13;
            // 
            // RunningLabel2
            // 
            this.RunningLabel2.AutoSize = true;
            this.RunningLabel2.Location = new System.Drawing.Point(349, 45);
            this.RunningLabel2.Name = "RunningLabel2";
            this.RunningLabel2.Size = new System.Drawing.Size(13, 13);
            this.RunningLabel2.TabIndex = 12;
            this.RunningLabel2.Text = "0";
            // 
            // RunningLabel1
            // 
            this.RunningLabel1.AutoSize = true;
            this.RunningLabel1.Location = new System.Drawing.Point(266, 46);
            this.RunningLabel1.Name = "RunningLabel1";
            this.RunningLabel1.Size = new System.Drawing.Size(76, 13);
            this.RunningLabel1.TabIndex = 11;
            this.RunningLabel1.Text = "Running Time:";
            // 
            // StartLabel2
            // 
            this.StartLabel2.AutoSize = true;
            this.StartLabel2.Location = new System.Drawing.Point(349, 29);
            this.StartLabel2.Name = "StartLabel2";
            this.StartLabel2.Size = new System.Drawing.Size(13, 13);
            this.StartLabel2.TabIndex = 10;
            this.StartLabel2.Text = "0";
            // 
            // StartLabel1
            // 
            this.StartLabel1.AutoSize = true;
            this.StartLabel1.Location = new System.Drawing.Point(266, 29);
            this.StartLabel1.Name = "StartLabel1";
            this.StartLabel1.Size = new System.Drawing.Size(58, 13);
            this.StartLabel1.TabIndex = 9;
            this.StartLabel1.Text = "Start Time:";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(670, 45);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(96, 23);
            this.StartBtn.TabIndex = 8;
            this.StartBtn.Text = "Start Process";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StartTextBox
            // 
            this.StartTextBox.Location = new System.Drawing.Point(494, 48);
            this.StartTextBox.Name = "StartTextBox";
            this.StartTextBox.Size = new System.Drawing.Size(145, 20);
            this.StartTextBox.TabIndex = 7;
            // 
            // CPULabel2
            // 
            this.CPULabel2.AutoSize = true;
            this.CPULabel2.Location = new System.Drawing.Point(227, 45);
            this.CPULabel2.Name = "CPULabel2";
            this.CPULabel2.Size = new System.Drawing.Size(13, 13);
            this.CPULabel2.TabIndex = 6;
            this.CPULabel2.Text = "0";
            // 
            // CPULabel1
            // 
            this.CPULabel1.AutoSize = true;
            this.CPULabel1.Location = new System.Drawing.Point(140, 45);
            this.CPULabel1.Name = "CPULabel1";
            this.CPULabel1.Size = new System.Drawing.Size(66, 13);
            this.CPULabel1.TabIndex = 5;
            this.CPULabel1.Text = "CPU Usage:";
            // 
            // MemLabel2
            // 
            this.MemLabel2.AutoSize = true;
            this.MemLabel2.Location = new System.Drawing.Point(227, 29);
            this.MemLabel2.Name = "MemLabel2";
            this.MemLabel2.Size = new System.Drawing.Size(13, 13);
            this.MemLabel2.TabIndex = 4;
            this.MemLabel2.Text = "0";
            // 
            // MemLabel1
            // 
            this.MemLabel1.AutoSize = true;
            this.MemLabel1.Location = new System.Drawing.Point(140, 29);
            this.MemLabel1.Name = "MemLabel1";
            this.MemLabel1.Size = new System.Drawing.Size(81, 13);
            this.MemLabel1.TabIndex = 3;
            this.MemLabel1.Text = "Memory Usage:";
            // 
            // EndBtn
            // 
            this.EndBtn.Location = new System.Drawing.Point(16, 24);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(95, 23);
            this.EndBtn.TabIndex = 2;
            this.EndBtn.Text = "End Proccess";
            this.EndBtn.UseVisualStyleBackColor = true;
            this.EndBtn.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // ProcessListBox
            // 
            this.ProcessListBox.FormattingEnabled = true;
            this.ProcessListBox.Location = new System.Drawing.Point(16, 73);
            this.ProcessListBox.Name = "ProcessListBox";
            this.ProcessListBox.Size = new System.Drawing.Size(750, 303);
            this.ProcessListBox.TabIndex = 1;
            this.ProcessListBox.SelectedIndexChanged += new System.EventHandler(this.ProcessListBox_SelectedIndexChanged);
            this.ProcessListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ProcessListBox_MouseDoubleClick);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // TopCheckBox
            // 
            this.TopCheckBox.AutoSize = true;
            this.TopCheckBox.Location = new System.Drawing.Point(16, 50);
            this.TopCheckBox.Name = "TopCheckBox";
            this.TopCheckBox.Size = new System.Drawing.Size(98, 17);
            this.TopCheckBox.TabIndex = 15;
            this.TopCheckBox.Text = "Always On Top";
            this.TopCheckBox.UseVisualStyleBackColor = true;
            this.TopCheckBox.CheckedChanged += new System.EventHandler(this.TopCheckBox_CheckedChanged);
            // 
            // AllCommBtn
            // 
            this.AllCommBtn.Location = new System.Drawing.Point(652, 384);
            this.AllCommBtn.Name = "AllCommBtn";
            this.AllCommBtn.Size = new System.Drawing.Size(114, 23);
            this.AllCommBtn.TabIndex = 16;
            this.AllCommBtn.Text = "Show All Comments";
            this.AllCommBtn.UseVisualStyleBackColor = true;
            this.AllCommBtn.Click += new System.EventHandler(this.AllCommBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 428);
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
        private System.Windows.Forms.Button EndBtn;
        private System.Windows.Forms.Label MemLabel1;
        private System.Windows.Forms.Label MemLabel2;
        private System.Windows.Forms.Label CPULabel1;
        private System.Windows.Forms.Label CPULabel2;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.TextBox StartTextBox;
        private System.Windows.Forms.Label StartLabel1;
        private System.Windows.Forms.Label StartLabel2;
        private System.Windows.Forms.Label RunningLabel2;
        private System.Windows.Forms.Label RunningLabel1;
        private System.Windows.Forms.Button CommentBtn;
        private System.Windows.Forms.TextBox CommentBox;
        private System.Windows.Forms.CheckBox TopCheckBox;
        private System.Windows.Forms.Button AllCommBtn;
    }
}

