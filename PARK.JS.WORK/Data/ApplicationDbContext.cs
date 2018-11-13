using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PARK.JS.WORK.Models.ApplicationModel;

namespace PARK.JS.WORK.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, String>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<PARK.JS.WORK.Models.ApplicationModel.ApplicationRole> ApplicationRole { get; set; }
    }
}
