using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VGEC.Models
{
    public class Student:IPerson
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String E_Id { get; set; }
        

        public string Email { get; set; }

        public string Contact { get; set; }

        [Required]
        public int C_Id { get; set; }
    }
}