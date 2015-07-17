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
            String URL = "http://vk.com/gingercat_che";
            HttpWebRequest objWebRequest;
            HttpWebResponse objWebResponse;
            StreamReader streamReader;
            //String strHTML;
            objWebRequest = (HttpWebRequest)WebRequest.Create(URL);
            objWebRequest.Method = "GET";
            objWebResponse = (HttpWebResponse)objWebRequest.GetResponse();
            streamReader = new StreamReader(objWebResponse.GetResponseStream());
            //strHTML = streamReader.ReadToEnd();
            ViewBag.Page = streamReader.ReadToEnd();
            //txtResponse.Text = strHTML;
            streamReader.Close();
            objWebResponse.Close();
            objWebRequest.Abort();
            return View();
        }
    }
}
