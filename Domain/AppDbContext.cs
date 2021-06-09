using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_Company_Core.Domain.Entities;

namespace MVC_Company_Core.Domain
{
    public class AppDbContext :IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "6216c364-e75a-4617-8439-5e4963cf7ee1",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "6039d1f4-2ffe-4d3f-84c5-8ae2e6daaf68",
                UserName = "awowed",
                NormalizedUserName = "AWOWED",
                Email = "messi5serg@gmail.com",
                NormalizedEmail = "MESSI5SERG@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "root"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "6216c364-e75a-4617-8439-5e4963cf7ee1",
                UserId = "6039d1f4-2ffe-4d3f-84c5-8ae2e6daaf68"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("fc00f9a1-b149-4097-9298-3b453f6e623c"),
                CodeWord = "PageIndex",
                Title = "Main"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("b83dfd24-9bf6-445d-928a-c91cccd07adc"),
                CodeWord = "PageServices",
                Title = "Our Services"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("f915b8ea-1ee8-4ffb-a747-d3dd15e795b5"),
                CodeWord = "PageContacts",
                Title = "Our Contacts"
            });

        }
    }
}
