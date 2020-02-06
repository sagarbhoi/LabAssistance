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
        public ActionResult Index(Admin  admin)
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
    }
}