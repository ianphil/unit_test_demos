using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CSE.Web.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

        //public SchoolContext() { }

        public DbSet<Student> Students { get; set; }
    }
}
