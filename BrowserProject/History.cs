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
    public partial class History : Form
    {
        ControlData historyControlObj;
        MyBrowser mainWindows;

        public History()
        {
            historyControlObj = new ControlData();
            InitializeComponent();
        }

        public History(ControlData mycontrol, MyBrowser main)
        {
            mainWindows = main;
            this.historyControlObj = mycontrol;
            InitializeComponent();
            MyListOfHistory.DataSource = mycontrol.GetHistoryControl();
            MyListOfHistory.Show();
        }
    }
}
