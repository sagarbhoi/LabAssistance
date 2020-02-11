using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VGEC.Models
{
    public class Mentor : IPerson
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int C_Id { get; set; }
        [Required]
        public int Fac_Id { get; set; }
        [Required]
        public int Sem { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}