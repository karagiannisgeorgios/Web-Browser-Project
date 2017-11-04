using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Net;

namespace BrowserProject
{
    public partial class MyBrowser : Form
    {
        // i set a new object from ControlData class and my forms

        ControlData MainControlObj = new ControlData();
        RenameForm renameForm;
        History historyForm;
        HomePage homePageForm;
        FavoritesName FavoritesNameForm;
        TabPage addTab;

        public MyBrowser()
        {

            InitializeComponent();


            //i make tabs and textbox
            addTab = new TabPage("New Tab");
            main_HTML_Area.TabPages.Add(addTab);
            TextBox tBox = new TextBox();
            tabPage1.Controls.Add(tBox);
            tBox.Dock = DockStyle.Fill;
            tBox.Multiline = true;
            tBox.ScrollBars = ScrollBars.Vertical;

            //the first time the home.txt will not exist
            if (File.Exists("home.txt"))
            {
                textbox_URL.Text = MainControlObj.GetHomePageControl();
                main_HTML_Area.SelectedTab.Text = textbox_URL.Text;
                htmlPage(MainControlObj.Page(new Uri(textbox_URL.Text)));
            }
            
            //the first time the history.txt will not exist
            if (File.Exists("history.txt"))
            {
                 MainControlObj.SetHistoryControl(textbox_URL.Text);
            }

            //the first time the Favorites.xml will not exist
            if (File.Exists("Favorites.xml"))
            {
               MyListOfFavorites.DataSource = MainControlObj.GetFavouriteControl();
            }
        }

     
        
        // Button History in order to see the history, open the form History
        private void button_HISTORY_Click(object sender, EventArgs e)
        {
            try
            {
                historyForm = new History(MainControlObj, this);
                historyForm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("there is no history yet!");
            }
        }

       
       
  
        //Button See Favorites
        private void button_SEE_YOUR_FAVORITES_Click(object sender, EventArgs e)
        {
            try
            {
                MyListOfFavorites.DataSource= MainControlObj.GetFavouriteControl();
            }
           catch (Exception)
            {
                MessageBox.Show("there is no favorites yet!");
            }
        }

       
        

        //visit a site from favorites
       private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                 textbox_URL.Text = MainControlObj.SearchFavoriteControl(MyListOfFavorites.SelectedItem.ToString());
                
                 MainControlObj.SetHistoryControl(textbox_URL.Text);

                 main_HTML_Area.SelectedTab.Text = textbox_URL.Text;
                 htmlPage(MainControlObj.Page(new Uri(textbox_URL.Text)));


            }
            catch (Exception)
            {
                MessageBox.Show("Xmmm..... you don't have favorites to visit..");
            }

        }

      


        //edit favorites
        private void button_EDIT_FAVORITE_Click(object sender, EventArgs e)
        {
            try
            {
                renameForm = new RenameForm(MyListOfFavorites.SelectedItem.ToString());
                renameForm.Show();
                MyListOfFavorites.DataSource = MainControlObj.GetFavouriteControl();
            }
            catch (Exception)
            {
                MessageBox.Show("Xmmm.... there is no any favorite to edit! Sorry");
            }
        }




        //delete favorite
        private void button_DELETE_FAVORITE_Click(object sender, EventArgs e)
        {
            try
            {
                MainControlObj.RemoveFavouriteControl(MyListOfFavorites.SelectedItem.ToString());
                MyListOfFavorites.DataSource = MainControlObj.GetFavouriteControl();
            }
            catch (Exception)
            {
                MessageBox.Show("You do not have any Favorite site to delete... Sorry");
            }
        }



        //I order to save as bookmark the URL have visit
        private void button_ADD_TO_FAVORITES_Click(object sender, EventArgs e)
        {
            FavoritesNameForm = new FavoritesName(MainControlObj, this);
            FavoritesNameForm.Show();
        }



        // In order to set my home address
        private void button_SET_HOME_PAGE_Click(object sender, EventArgs e)
        {
            homePageForm = new HomePage();
            homePageForm.Show();
        }

     
        //In order to communicate with the site
        private void Button_GO_Click(object sender, EventArgs e)
        {
            try
            {
                htmlPage(MainControlObj.Page(new Uri(textbox_URL.Text)));
                MainControlObj.SetHistoryControl(textbox_URL.Text);
                main_HTML_Area.SelectedTab.Text = textbox_URL.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Xmmm..... you have to write a proper URL... ");
            }
        }



        //Only takes the address which is in the url textbox
        public string GetAddress()
        {
           return textbox_URL.Text;
        }

        
        
        //return the html code
        public void htmlPage(string html)
        {
            main_HTML_Area.SelectedTab.Controls[0].Text = MainControlObj.Page(new Uri(textbox_URL.Text));
        }


        //creates new Tab
        private void main_HTML_Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (main_HTML_Area.SelectedTab == addTab)
            {
                var index = main_HTML_Area.TabPages.Count - 1;
                var newTab = new TabPage("New WebSite");
                TextBox tBox = new TextBox();
                newTab.Controls.Add(tBox);

                tBox.Dock = DockStyle.Fill;
                tBox.Multiline = true;
                main_HTML_Area.TabPages.Insert(index, newTab);
                main_HTML_Area.SelectedTab = newTab;
            }

            if (main_HTML_Area.SelectedTab.Text == "New WebSite")
                textbox_URL.Text = "http://";
            else
                textbox_URL.Text = main_HTML_Area.SelectedTab.Text;
        }



        //close tab
        private void Close_TAB_Click(object sender, EventArgs e)
        {
            main_HTML_Area.TabPages.RemoveAt(main_HTML_Area.SelectedIndex);
        }

        // in order to visit the home page any time the user wants
        private void GO_TO_HOME_PAGE_Click(object sender, EventArgs e)
        {
            try
            {
                textbox_URL.Text = MainControlObj.GetHomePageControl();
                MainControlObj.SetHistoryControl(textbox_URL.Text);
                main_HTML_Area.SelectedTab.Text = textbox_URL.Text;
                htmlPage(MainControlObj.Page(new Uri(textbox_URL.Text)));
            }
            catch (Exception)
            {
                MessageBox.Show("you have not set a homepage yet... ");
            }
        }
    }
}


