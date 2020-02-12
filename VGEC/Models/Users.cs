using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VGEC.Models
{
    public enum Users
    {
        [Display(Name = "Select User")]
        SelectUser,
        Student,
        Faculty,
        Mentor,
        Admin
    }
    
}