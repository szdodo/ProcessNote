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


namespace ProcessNote
{
    public partial class Form1 : Form
    {
        Process[] processlist = Process.GetProcesses();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EndBtn.Enabled = false;
            CommentBtn.Enabled = false;
            foreach (Process theprocess in processlist)
            {
                ProcessListBox.Items.Add(theprocess.Id+"\t"+ theprocess.ProcessName);
            }
        }

        private void ProcessListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EndBtn.Enabled = true;
            CommentBtn.Enabled = true;
            UpdateData();
        }

        private void UpdateData()
        {
            if (ProcessListBox.SelectedIndex < 0)
            {
                return;
            }
            Process currentProc = processlist[ProcessListBox.SelectedIndex];
            long memoryUsed = currentProc.PrivateMemorySize64 % 1000;
            MemLabel2.Text = memoryUsed + " K";

            try
            {
                StartLabel2.Text = currentProc.StartTime.ToString();
            }
            catch (Win32Exception)
            {
                StartLabel2.Text = "No Data Available";
            }

            try
            {
                RunningLabel2.Text = currentProc.TotalProcessorTime.ToString();
            }
            catch (Win32Exception)
            {
                RunningLabel2.Text = "No Data Available";
            }
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            processlist[ProcessListBox.SelectedIndex].Kill();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            string NewProc = StartTextBox.Text;
            Process process = new Process();
            process.StartInfo.FileName = NewProc;
            try{
                process.Start();
            }
            catch(System.ComponentModel.Win32Exception){
                MessageBox.Show("Invalid input, no process found!");
            }
        }

        private void CommentBtn_Click(object sender, EventArgs e)
        {
            var comment = CommentBox.Text;
            var newContent = ProcessListBox.SelectedItem + "\t\t\t\t" + comment;
            ProcessListBox.Items[ProcessListBox.SelectedIndex] = newContent;
            CommentBox.Clear();
        }

        private void ProcessListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UpdateData();
        }
    }
}
