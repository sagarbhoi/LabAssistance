using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VGEC.Models;

namespace VGEC.ViewModel
{
    public class AdminViewModal :IAdminViewModel
    {
        private readonly VgecDbContext db;
        public AdminViewModal(VgecDbContext db)
        {
            this.db = db;
        }

        public void AddFaculty(Faculty faculty)
        {
            db.faculties.Add(faculty);
            db.SaveChanges();
        }

        public void AddSubject(Subject sub)
        {
            db.subjects.Add(sub);
            db.SaveChanges();
        }

        public bool Authenticate(IPerson person) 
        {
          var check=  db.admins.FirstOrDefault(x=>x.UserName.Equals(person.UserName) && x.Password.Equals(person.Password));
            if (check == null)
                return false;
            return true;
        }

        public IEnumerable<Faculty> GetAllFacuilty()
        {
            return db.faculties.OrderBy(x=>x.UserName).ToList();
        }
        public IEnumerable<Subject> GetAllSubject()
        {
            return db.subjects.OrderBy(x => x.Subject_Name).ToList();
        }
    }
}