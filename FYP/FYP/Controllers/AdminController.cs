using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FYP.Models;
using System.Data.Mapping;

namespace FYP.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        CMSdbEntities dbEntity = new CMSdbEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StoreNewTeacherinDB(user u)
        {
            CMSdbEntities dbEntities = new CMSdbEntities();
            string day = Request["date"];
            string month = Request["month"];
            string year = Request["year"];
            string gender = Request["gender"];
            if (gender.Equals("0"))
                gender = "male";
            else
                gender = "female";

            string date = day + "-" + month + "-" + year;
            u.userID = "teacher";

            u.status = true;
            u.dateOFBirth = System.DateTime.Today;
            u.admissionDate = System.DateTime.Today;
            //.admissionDate = "";
            //int teacherID = (int)Session["userID"];
            //c.TeacherID = teacherID;
            //c.Status = "ACTIVE";
            dbEntities.users.Add(u);
           dbEntities.SaveChanges();
            return View();

        }

    }
}
