using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FindJourneyworkWeb.Models;
using System.Data.Entity;

//定义映射关系
//数据访问层
namespace FindJourneyworkWeb.DataAccessLaye
{
    public class UserERPDAL :DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("TblUser");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
    }
}