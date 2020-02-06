using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VGEC.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Semester { get; set; }
        [Required]
        public String Subject_Name { get; set; }
        [Required]
        public int Sub_Code { get; set; }
        [DefaultValue(false)]
        public bool IsElective { get; set; }
        [DefaultValue(false)]
        public bool IsActive { get; set; }
    }
}