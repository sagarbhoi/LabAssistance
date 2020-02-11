using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VGEC.Models
{
    public class Faculty:IPerson
    {
        [Key]
        public int Fac_Id { get; set; }
       // [Column(TypeName = "varchar(100)")]
        
       // [Column(TypeName = "varchar(100)")]
        public String Email { get; set; }
       // [Column(TypeName = "varchar(100)")]
        public String ContactNo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}