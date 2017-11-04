using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserProject
{
    public partial class RenameForm : Form
    {

        string SelectedName;
        ControlData myControl = new ControlData();


        public RenameForm(string SelectedName)
        {
            this.SelectedName = SelectedName;
            InitializeComponent();
        }


        private void OK_Click(object sender, EventArgs e)
        {
            myControl.RenameFavoriteControl(SelectedName, textBox1.Text);
            this.Close();
        }
    }
}
