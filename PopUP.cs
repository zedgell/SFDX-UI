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
        public static string root;
        public static string ProjectName;
        public PopUP()
        {
            InitializeComponent();
            root = Form1.root;
            label2.Text = root;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            ProjectName = projectNameText.Text;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Change_Directory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog
            {
                ShowNewFolderButton = true
            };
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                root = folderDlg.SelectedPath;
                label2.Text = root;
            }
        }
    }
}
