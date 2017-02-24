using FindJourneyworkWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FindJourneyworkWeb.DataAccessLaye
{
    public class TypeUserERPDAL : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypeUser>().ToTable("TblTypeUser");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<TypeUser> TypeUsers { get; set; }
    }
   
}