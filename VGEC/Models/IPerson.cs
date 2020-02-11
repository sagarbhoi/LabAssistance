using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VGEC.Models
{
    public interface IPerson
    {[Required]
         String UserName { get; set; }
        [Required]
         String Password { get; set; }
    }
}