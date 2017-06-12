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
            foreach (Process theprocess in processlist)
            {
                ProcessListBox.Items.Add(theprocess.Id+"\t"+ theprocess.ProcessName);
            }
        }

        private void ProcessListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process currentProc = processlist[ProcessListBox.SelectedIndex];
            long memoryUsed = currentProc.PrivateMemorySize64;
            MemLabel2.Text=memoryUsed+" ";
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
            catch(System.ComponentModel.Win32Exception){}
        }
    }
}
