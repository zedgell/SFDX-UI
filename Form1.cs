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
        string root;
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
            process.WaitForExit();
        }

        // dev hub
        private void Class11_Click(object sender, EventArgs e)
        {
            if(root != null)
            {
                string Command = "sfdx force:org:open -u DevHub";
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    WorkingDirectory = root,
                    UseShellExecute = false,
                    Arguments = "/C " + Command,
                    Verb = "runas",
                    RedirectStandardOutput = true
                };
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FolderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            
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
                root = folderDlg.SelectedPath;
            }
        }

        private void CreateProject_Click(object sender, EventArgs e)
        {

            PopUP popUpWindow = new PopUP();
            DialogResult dialogresult = popUpWindow.ShowDialog();
            if(dialogresult == DialogResult.OK)
            {
                if (root != null)
                {
                    string ProjectName = PopUP.ProjectName;
                    string Command = "sfdx force:project:create -n " + ProjectName;
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        WorkingDirectory = root,
                        UseShellExecute = false,
                        Arguments = "/C " + Command,
                        Verb = "runas",
                        RedirectStandardOutput = true
                    };
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    popUpWindow.Dispose();
                }
            }
            else
            {
                popUpWindow.Dispose();
            }
        }
    }
}
