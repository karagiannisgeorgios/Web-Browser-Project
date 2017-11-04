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
using System.Xml;

namespace BrowserProject
{

   
    public class Data
    {


        
        /*-------------------------------Favorites-----------------------------------------------------------*/

        //I add to favorites using the string for the name and a string for the URL
        public void AddFavorite(string name, string url)
        {
            XmlDocument myXml = new XmlDocument();
            XmlElement el = myXml.CreateElement("favorit");
            //attribute for the elements


            el.SetAttribute("url", url);
            el.InnerText = name;
            //if the file exists 
            //append a new child in the favorites root


            if (!File.Exists("Favorites.xml"))
            {
                XmlElement root = myXml.CreateElement("favorites");
                myXml.AppendChild(root);
                root.AppendChild(el);
            }
            else
            {
                myXml.Load("Favorites.xml");
                myXml.DocumentElement.AppendChild(el);
            }

            myXml.Save("Favorites.xml");
        }




        //In order to remove a node from the favorites.xml
        public void RemoveFavourite(string SelectedName)
        {
            XmlDocument myXml = new XmlDocument();
            myXml.Load("Favorites.xml");

            foreach (XmlElement x in myXml.DocumentElement.ChildNodes)
            {
                if (x.InnerText.Equals(SelectedName))
                {
                    x.ParentNode.RemoveChild(x);
                    //x.InnerText = NewName;
                    break;
                }
            }

            myXml.Save("Favorites.xml");
        }

    
        
       
        
        //in order to return the list with the favorites
        public List<string> GetFavourite()
        {
            List<string> myFavorites = new List<string>();
            XmlTextReader reader = new XmlTextReader("Favorites.xml");
            XmlNodeType type;
            while (reader.Read())
            {
                type = reader.NodeType;
                if (type == XmlNodeType.Element)
                {

                    if (reader.Name == "favorit")
                    {

                        reader.Read();
                        myFavorites.Add(reader.Value);
                    }
                }
            }
            reader.Close();
            return myFavorites;
        }





        //i have this method in order to rename a node (a fovorite) in the favorite.xml
        public void RenameFavorite(string SelectedName, string NewName)
        {
            XmlDocument myXml = new XmlDocument();
            myXml.Load("Favorites.xml");

            foreach (XmlElement x in myXml.DocumentElement.ChildNodes)
            {
                if (x.InnerText.Equals(SelectedName))
                {

                    x.InnerText = NewName;
                    break;
                }
            }

            myXml.Save("Favorites.xml");
        }




        //i search every node in the favorites.xml in order to find that the user chose in order to gine him back the url
        public string SearchFavorite(string SelectedValue)
        {
            XmlDocument myXml = new XmlDocument();
            myXml.Load("Favorites.xml");
            string url = "";
            foreach (XmlElement x in myXml.DocumentElement.ChildNodes)
            {
                if (x.InnerText.Equals(SelectedValue))
                {
                    url = x.GetAttribute("url");
                    break;
                }
            }
            return url;
        }







        /*-------------------------------history-----------------------------------------------------------*/
        // I keep the history of the browser in a .txt file 
        public void SetHistory(string url)
        {
            StreamWriter sw = new StreamWriter("history.txt", true);
            sw.WriteLine(url);
            sw.Close();
        }



        // I return a list with the history reading the history.txt
        public List<string> GetHistory()
        {
            List<string> historylist = new List<string>();
            using (StreamReader sr = new StreamReader("history.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    historylist.Add(line); // Add to list.
                }
                sr.Close();
                return historylist;
            }
        }



        /*-------------------------------Home Page-----------------------------------------------------------*/

        //i set my home page
        public void SetHomePage(Uri homePage)
        {
                StreamWriter sw = new StreamWriter("home.txt");
                sw.Write(homePage);
                sw.Close();
        }



        //I take back my home page
        public string GetHomePage()
        {
            StreamReader sr = new StreamReader("home.txt");
            string homepage = sr.ReadLine().ToString();
            sr.Close();
            return homepage;
        } 
    }
}
