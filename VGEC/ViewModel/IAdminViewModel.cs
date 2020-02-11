using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VGEC.Models;

namespace VGEC.ViewModel
{
    public interface IAdminViewModel
    {
         bool Authenticate(IPerson person);
        IEnumerable<Faculty> GetAllFacuilty();

        void AddFaculty(Faculty faculty);
        IEnumerable<Subject> GetAllSubject();
        void AddSubject(Subject f);
    }
}