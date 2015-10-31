using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FYP.Models;
using System.Data.Mapping;

namespace FYP.Controllers
{
    public class homeController : Controller
    {
        CMSdbEntities dbEntity = new CMSdbEntities();
        //
        // GET: /home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult login()
        {
            return View();
        }
        public ActionResult transfer()
        {
            string userId = Request["userId"];
            string pwd = Request["pwd"];
            user u = dbEntity.users.First(n => n.password.Equals(pwd) );
            return View();
        }

    }
}
