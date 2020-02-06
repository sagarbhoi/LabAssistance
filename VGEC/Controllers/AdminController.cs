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
        private readonly AdminViewModal adminviewmodal;
        public AdminController(AdminViewModal avm)
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
                return RedirectToAction("Home","Admin");
            }
            else
            {
                TempData["error"] = "Wrong Credential";
                return View();

            }
        }
    }
}