using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VGEC.Models;
using VGEC.ViewModel;

namespace VGEC.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminViewModel adminviewmodal;
        public AdminController(IAdminViewModel avm)
        {
            this.adminviewmodal = avm;
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(VGEC.Models.Admin admin)
        {
            if(adminviewmodal.Authenticate(admin))
            {
                Session["user"] = admin.UserName;
                return View("Home",admin);
            }
            else
            {
                TempData["error"] = "Wrong Credential";
                return View();

            }
        }
        public ActionResult Home()
        {   if (Session["user"] != null)
            {
                return View();
            }
            else
            {
                return View("Index");
            }
        }
        public ActionResult Logout()
        {
            Session.Remove("user");
            return View("Index");
        }
        public ActionResult AddSubject()
        {
            return View(adminviewmodal.GetAllSubject()) ;
        }
        [HttpPost]
        public ActionResult AddSubject(Subject sub)
        {
            adminviewmodal.AddSubject(sub);
            return View(adminviewmodal.GetAllSubject());
        }
        public ActionResult AddFaculty()
        {
            return View(adminviewmodal.GetAllFacuilty());
        }
        [HttpPost]
        public ActionResult AddFaculty(Faculty f)
        {
            adminviewmodal.AddFaculty(f);
            return View(adminviewmodal.GetAllFacuilty());
        }
    }
}