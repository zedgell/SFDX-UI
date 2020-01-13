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
        public static string root = "C:\\";
        public Form1()
        {
            InitializeComponent();
            Current_folder.Text = root;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string Command = "sfdx force:auth:web:login -d -a DevHub";
            Cmd_start(Command, root);
        }

        // dev hub
        private void Class11_Click(object sender, EventArgs e)
        {
            if(root != "")
            {
                string Command = "sfdx force:org:open -u DevHub";
                Cmd_start(Command, root);
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
                Current_folder.Text = root;
            }
        }

        private void CreateProject_Click(object sender, EventArgs e)
        {
            PopUP popUpWindow = new PopUP();
            DialogResult dialogresult = popUpWindow.ShowDialog();
            if (root != "" && root != "Please Chose a Directory")
            {
                if (dialogresult == DialogResult.OK)
                {
                    if (PopUP.root != root)
                    {
                        root = PopUP.root;
                    }
                    string ProjectName = PopUP.ProjectName;
                    string Command = "sfdx force:project:create -n " + ProjectName;
                    Cmd_start(Command, root);
                    popUpWindow.Dispose();
                }
                else
                {
                    popUpWindow.Dispose();
                }
            }
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
