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
    public partial class HomePage : Form
    {
        ControlData homePageControlObj = new ControlData();


        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               homePageControlObj.SetHomePageControl(new Uri(address.Text));
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("this in not a URL.....");
            }

        }


    }

}
