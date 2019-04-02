namespace SystemWeb.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using SystemWeb.Model.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<SystemWeb.Data.SystemDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SystemWeb.Data.SystemDbContext context)
        {
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new SystemDbContext()));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new SystemDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "duc",
                Email = "ducluongchung@gmail.com",
                EmailConfirmed = true,
                BirthDay = DateTime.Now,
                FullName = "Lương Văn Chung Đức"

            };

            manager.Create(user, "123654$");

            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }

            var adminUser = manager.FindByEmail("ducluongchung@gmail.com");

            manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });

        }
    }
}
