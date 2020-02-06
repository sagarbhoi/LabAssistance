using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VGEC.Models
{
    public class Mentor: IPerson
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int C_Id { get; set; }
        [Required]
        public int F_Id { get; set; }
        [Required]
        public int Sem { get; set; }
    }
}