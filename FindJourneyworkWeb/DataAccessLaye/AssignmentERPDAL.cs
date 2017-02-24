using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.d
using System.Data.Entity;
using FindJourneyworkWeb.Models;

namespace FindJourneyworkWeb.DataAccessLaye
{
    public class AssignmentERPDAL: DbContext
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignment>().ToTable("TblAssignment");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Assignment> Assignments { get; set; }
    }
}