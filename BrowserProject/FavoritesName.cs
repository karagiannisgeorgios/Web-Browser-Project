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
    public partial class FavoritesName : Form
    {
       ControlData myControl = new ControlData();
        MyBrowser mainWindow = new MyBrowser();

        public FavoritesName(ControlData myControl, MyBrowser mainWindow)
        {
            this.mainWindow = mainWindow;
            this.myControl = myControl;
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
           
                myControl.AddFavoriteControl(textBox_NAME.Text, mainWindow.GetAddress());
                Close();
            
        }
    }
}
