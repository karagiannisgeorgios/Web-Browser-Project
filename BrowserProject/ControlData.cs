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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BrowserProject
{
    /*-------------------------------The CONTROL part-----------------------------------------------------------*/
    //I have this class in order to control my data, in order have access to my Data class functions and to send the results to GUI



    public class ControlData
    {
        private Data data = new Data();



        /*-------------------------------Control Favorites-----------------------------------------------------------*/
        //I use the methods below to control my favorites from DATA part without instant access to them


        public void AddFavoriteControl(string name, string url)
        {
            data.AddFavorite(name, url);
        }



        public void RemoveFavouriteControl(string selectedName)
        {
            data.RemoveFavourite(selectedName);
        }



        public List<string> GetFavouriteControl()
        {
            return data.GetFavourite();
        }



        public void RenameFavoriteControl(string selectedName, string NewName)
        {
            data.RenameFavorite(selectedName, NewName);
        }



        public string SearchFavoriteControl(string value)
        {
            return data.SearchFavorite(value);
        }


        /*-------------------------------Control History-----------------------------------------------------------*/



        public void SetHistoryControl(string adress)
        {
            data.SetHistory(adress);
        }



        public List<string> GetHistoryControl()
        {
            return data.GetHistory();
        }





        /*-------------------------------Control HomePage-----------------------------------------------------------*/
        public void SetHomePageControl(Uri siteUrl)
        {
            data.SetHomePage(siteUrl);


        }


        public string GetHomePageControl()
        {
            string homepage = data.GetHomePage();
            return homepage;

        }




        /*-------------------------------Control Comunicate with page's Server - my browser-----------------------------------------------------------*/
        public string BrowserRequests(Uri siteUrl)
        {

            HttpWebResponse WebResp = null;
            string html = "";
            //i send a web request and i receive the answer, i store the answer in a string and i return the string, the HTML code
            try
            {
                HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(siteUrl);
                WebReq.Method = "GET";

                WebResp = (HttpWebResponse)WebReq.GetResponse();

                Stream Answer = WebResp.GetResponseStream();
                StreamReader _Answer = new StreamReader(Answer);
                html = _Answer.ReadToEnd();
                _Answer.Close();
                WebResp.Close();
                return html;

            }
            //exception handling, i return a message based in the error code
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    WebResp = (HttpWebResponse)ex.Response;
                    int error = (int)WebResp.StatusCode;
                    if (error == 404)
                    {
                        html = ("404 Not Found");
                        return html;
                    }
                    else if (error == 403)
                    {
                        html = ("403 Forbidden");
                        return html;
                    }
                    else if (error == 400)
                    {
                        html = ("400 Bad Request");
                        return html;
                    }
                    WebResp.Close();
                    return html;
                }
                else
                {
                    html = ("Error: {0} " + ex.Status);
                    return html;
                }
            }
            finally
            {
                if (WebResp != null)
                {
                    WebResp.Close();

                }
            }
        }







        /*-------------------------------the TASK part, use these methods in order to have tabs-----------------------------------------------------------*/



        //Creates and starts a task, 
        private Task<string> Asynchronous(Uri siteUrl)
        {
            return Task.Factory.StartNew(() => BrowserRequests(siteUrl));
        }



        public string Page(Uri siteUrl)
        {
            return Asynchronous(siteUrl).Result;
        }
    }
}
