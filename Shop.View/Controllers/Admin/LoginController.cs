using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers.Admin
{
    public class LoginController : Controller
    {
        /// <summary>
        /// Bootstrap
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// FlatUI
        /// </summary>
        /// <returns></returns>
        public ActionResult Index2()
        {
            return View();
        }
    }
}