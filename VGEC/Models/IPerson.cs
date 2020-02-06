using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VGEC.Models
{
    public class IPerson
    {[Required]
        public String UserName { get; set; }
        [Required]
        public String Password { get; set; }
    }
}