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
            Run_Cmd(Command, root);
        }

        // dev hub
        private void Class11_Click(object sender, EventArgs e)
        {
            if(root != null)
            {
                string Command = "sfdx force:org:open -u DevHub";
                Run_Cmd(Command, root);
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
                    Run_Cmd(Command, root);
                    popUpWindow.Dispose();
                }
            }
            else
            {
                popUpWindow.Dispose();
            }
        }
        private void Run_Cmd(string command, string directory)
        {
            Cmd_start(command, directory);
        }
        private void Cmd_start(string command, string directory)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "cmd.exe",
                WorkingDirectory = directory,
                UseShellExecute = false,
                Arguments = "/C " + command,
                Verb = "runas",
                RedirectStandardOutput = true,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                CreateNoWindow = true
            };
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }
    }
}
