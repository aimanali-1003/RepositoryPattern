using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RepositoryPattern.Models
{
    public class db:DbContext
    {
        public DbSet<Student> students { get; set; }
    }
}