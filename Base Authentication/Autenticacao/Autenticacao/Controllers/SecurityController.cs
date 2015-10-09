using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
namespace Autenticacao.Controllers
{
    public class SecurityController : Controller
    {
        // GET: Security
        public ActionResult Login()
        {
            return View("Login");
        }
        [Authorize]
        public ActionResult About()
        {
            return View("About");
        }

        public ActionResult CheckUser()
        {
            if ((Request.Form["user"] == "123") && (Request.Form["pass"] == "123"))
            {
                FormsAuthentication.SetAuthCookie(Request.Form["user"], true);
                return View("About");
            }
            else
            {
                return View("Login");

            }
        }
    }
}