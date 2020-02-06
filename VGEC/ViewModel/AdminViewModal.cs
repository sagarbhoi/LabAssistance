using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VGEC.Models;

namespace VGEC.ViewModel
{
    public class AdminViewModal
    {
        private readonly VgecDbContext db;
        public AdminViewModal(VgecDbContext db)
        {
            this.db = db;
        }
        public bool Authenticate(IPerson admin)
        {
          var check=  db.admins.FirstOrDefault(x=>x.UserName.Equals(admin.UserName) && x.Password.Equals(admin.Password));
            if (check == null)
                return false;
            return true;
        }
    }
}