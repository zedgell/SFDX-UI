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
    //TODO: Add Button to Open in VScode, Add button to create a scratch org, add button to push to salesforce, add page to view project, add fuction to save scratch org login info.
    public partial class Form1 : Form
    {
        //current directory
        public static string root = "C:\\";
        public static string output;

        //Start the form and call the Update_Fields function
        public Form1()
        {
            bool SFDXInstalled = Is_SFDX_Installed();

            if (SFDXInstalled)
            {
                //Starts all the differnt components
                InitializeComponent();

                //Calls the update_fields function
                Update_fields();
            }
        }

        private bool Is_SFDX_Installed()
        {
            string SFDXCheck = "sfdx -v";
            Cmd_start(SFDXCheck, root);
            if (output.Contains("sfdx-cli"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Updates fields on start
        private void Update_fields()
        {
            //updates the Current folder field to the value set defined in the above string varible root
            Current_folder.Text = root;
        }

        //Send command and current directory to Cmd_start function to let user log in to salesforce
        private void Login_Click(object sender, EventArgs e)
        {
            //Defines the command to let users login to salesforce
            string Command = "sfdx force:auth:web:login -d -a DevHub";

            //Sends command and current directory to Cmd_start Function
            Cmd_start(Command, root);
        }

        //Lets user see there dev hub by sending the command and the current directory to the Cmd_start function
        private void Class11_Click(object sender, EventArgs e)
        {
            //defines the command to let users view there DevHub in salesforce
            string Command = "sfdx force:org:open -u DevHub";

            //Sends command and current directory to Cmd_start function
            Cmd_start(Command, root);
        }

        //Lets users select and set directory
        private void FolderSelect_Click(object sender, EventArgs e)
        {
            //creates a window for people to select a folder
            FolderBrowserDialog folderDlg = new FolderBrowserDialog
            {
                //allows users to create a new folder
                ShowNewFolderButton = true
            }; 

            //gets dialog from Folder select window
            DialogResult result = folderDlg.ShowDialog();

            //checks if dialog result OK
            if (result == DialogResult.OK)
            {
                //sets the root to the path selected by the user
                root = folderDlg.SelectedPath;

                //set the current folder text on the main window to the directory selected
                Current_folder.Text = root;
            }
        }

        //lets users create a project - more details below
        private void CreateProject_Click(object sender, EventArgs e)
        {
            //creates PopUP windows with the varble name PopUpWindow
            PopUP popUpWindow = new PopUP();
            
            //gets the dialog which in this case can be OK or Cancel
            DialogResult dialogresult = popUpWindow.ShowDialog();

            //Check if dialog is OK
            if (dialogresult == DialogResult.OK)
            {
                //Check to see if directory in PopUp window and in the main window are differnt
                if (PopUP.root != root)
                {
                    //If they are change directory in main window
                    root = PopUP.root;
                }
                
                //Grab the project name from the PopUp windows
                string ProjectName = PopUP.ProjectName;

                //Set the command varible to be passed into the Cmd_start function
                string Command = "sfdx force:project:create -n " + ProjectName;

                //pass the command and the current directory into the Cmd_start function
                Cmd_start(Command, root);

                //remove PopUp window
                popUpWindow.Dispose();
            }

            //if diolog is not OK remove PopUP Window
            else
            {
                //remove PopUp window
                popUpWindow.Dispose();
            }
        }

        //starts command prompt and takes two varibles in to define the command and the current directory
        private void Cmd_start(string command, string directory)
        {
            //Define a new process to run various .exe files
            System.Diagnostics.Process process = new System.Diagnostics.Process();

            //defines the diffent paramters
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                //Tells which .exe to run in this case it command prompt
                FileName = "cmd.exe",
                
                //Tells what directory to run in using the current directory
                WorkingDirectory = directory,

                //Tells whether to use shell execute
                UseShellExecute = false,

                //tell the argument to run in this case /C to make it close after it finishes and then the command to be run
                Arguments = "/C " + command,

                //Tells it to run as admin
                Verb = "runas",

                //redirects the output to the form. This will be used later to verify that it ran without errors
                RedirectStandardOutput = true,

                //Both are used together to make sure that command prompt is hidden
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                CreateNoWindow = true
            };

            //sets command prompt given the above parameters
            process.StartInfo = startInfo;

            //starts command prompt
            process.Start();

            output = process.StandardOutput.ReadToEnd();
            //Waits for the command to finish then closes the proccess
            process.WaitForExit();
        }
    }
}
