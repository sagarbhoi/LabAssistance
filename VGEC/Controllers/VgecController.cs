using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VGEC.Models;

namespace VGEC.Controllers
{
    public class VgecController : Controller
    {
        private readonly VgecDbContext db;
        public VgecController(VgecDbContext db)
        {
            this.db = db;
        }
        // GET: Vgec
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(String users)
        {
           
            String u = Enum.GetName(typeof(Users), Convert.ToInt32(users));
            return RedirectToAction("Index",u);
        }
    }
}