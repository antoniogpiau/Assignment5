using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Assignment5New.Models
{
    public partial class ECTDBContext : DbContext
    {
        public ECTDBContext()
            : base("name=ECTDBEntities")
        {
        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Post> Post { get; set; }

    }
}