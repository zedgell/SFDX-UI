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
        public static string ProjectName;
        public PopUP()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            ProjectName = projectNameText.Text;
        }
    }
}
