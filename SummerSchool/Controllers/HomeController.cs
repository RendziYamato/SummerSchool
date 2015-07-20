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
        [HttpGet]
        public ViewResult Index()
        {
            int groupID = 21247247;
            string URL = "";

            int myApplicationID = 5002040;
            int scope = 1;
            string display = "popup";
            string redirectURI = "https://oauth.vk.com/blank.html";

            string AuthorizationAddress = string.Format("https://oauth.vk.com/authorize?client_id={0}&redirect_uri={1}&scope={2}&display={3}&responce_type={4}&v={5}", myApplicationID, redirectURI, scope, display, "token", 5.34);

            Response.Redirect(AuthorizationAddress);
            return View();
        }
    }
}
