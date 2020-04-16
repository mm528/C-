using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Database_First_Try.Models;

namespace Database_First_Try.DAL
{
    public class mysqlContext : IdentityDbContext<ApplicationUser>
    {
        public mysqlContext(DbContextOptions<mysqlContext> option): base(option) 
        {
            this.Database.EnsureCreated();

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public virtual DbSet<Person> Persons { get; set; }
    }
}
