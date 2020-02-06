using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VGEC.Models
{

    public class VgecDbContext : DbContext
    {    
        public DbSet<Student> students { get; set; }
        public DbSet<Faculty> faculties { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<Mentor> mentors { get; set; }
        public DbSet<Admin> admins { get; set; }
    }
}