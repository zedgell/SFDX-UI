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
    public partial class PopUP : Form
    {
        //current directory
        public static string root;

        //project name
        public static string ProjectName;

        //stary the form
        public PopUP()
        {
            //Starts all the differnt components
            InitializeComponent();

            //Set the varible root to main form's varible root
            root = Form1.root;

            //Set the directory text to the value of the varible root
            label2.Text = root;
        }

        //Called when the user clicks the create button
        private void Create_Click(object sender, EventArgs e)
        {
            //Sets the ProjectName varible to the value of the text field projectNameText
            ProjectName = projectNameText.Text;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }


        //called when the change directory button is clicked
        private void Change_Directory_Click(object sender, EventArgs e)
        {
            //Opens folder select screen
            FolderBrowserDialog folderDlg = new FolderBrowserDialog
            {
                //Lets user create a new folder
                ShowNewFolderButton = true
            };

            //get the dialog results
            DialogResult result = folderDlg.ShowDialog();

            //If dialog results is equal to OK
            if (result == DialogResult.OK)
            {
                // set root to folder selected
                root = folderDlg.SelectedPath;
                //set the current directory lable to the new value of the root varible
                label2.Text = root;
            }
        }
    }
}
