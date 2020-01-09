using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFDXUI
{
    public partial class Form1 : Form
    {
        private string _output;
        public string labelText
        {
            get { return _output; }
            set
            {
                _output = value;
            }
        }
        string output;
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string Command = "sfdx force:auth:web:login -d -a DevHub";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "cmd.exe",
                WorkingDirectory = @"D:\code",
                UseShellExecute = false,
                Arguments = "/C " + Command,
                Verb = "runas",
                RedirectStandardOutput = true
            };
            process.StartInfo = startInfo;
            process.Start();
            output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            textBox1.Text = output;
        }

        private void Class11_Click(object sender, EventArgs e)
        {
            string Command = "sfdx force:org:open -u DevHub";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "cmd.exe",
                WorkingDirectory = @"D:\code",
                UseShellExecute = false,
                Arguments = "/C " + Command,
                Verb = "runas",
                RedirectStandardOutput = true
            };
            process.StartInfo = startInfo;
            process.Start();
            output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            textBox1.Text = output;

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FolderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            
        }
        public void ChooseFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void FolderSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog
            {
                ShowNewFolderButton = true
            }; 
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }
    }
}
