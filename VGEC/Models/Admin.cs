using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VGEC.Models
{
    public class Admin: IPerson
    {   [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}