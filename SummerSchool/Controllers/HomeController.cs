using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using System.Web.Security;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Net;

namespace SummerSchool.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            String siteURL = "http://vk.com/gingercat_che";

            HttpWebRequest myWebRequest;
            HttpWebResponse myWebResponse;
            StreamReader streamReader;
            
            myWebRequest = (HttpWebRequest)WebRequest.Create(siteURL);
            myWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
            streamReader = new StreamReader(myWebResponse.GetResponseStream());

            ViewBag.RecievedPage = streamReader.ReadToEnd();
            
            streamReader.Close();
            myWebResponse.Close();
            myWebRequest.Abort();
            return View();
        }
    }
}
