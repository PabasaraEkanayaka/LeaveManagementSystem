using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole 
                {
                    Id = "a5526f97-f4e9-42b4-89b8-c11a2abeb837",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"
                }, 
                new IdentityRole 
                {
                    Id = "b3f56533-b26a-4235-be4c-eb8927457656",
                    Name = "Supervisor",
                    NormalizedName = "SUPERVISOR"
                }, 
                new IdentityRole 
                {
                    Id = "79411413-675d-40d4-93e5-afc5ea04fc06",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }
                
              );

            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "fa556c12-0e07-4f3a-8487-4d422c590802",
                Email = "admin@bitzify.com",
                NormalizedEmail = "ADMIN@BITZIFY.COM",
                NormalizedUserName = "ADMIN@BITZIFY.COM",
                UserName = "admin@bitzify.com",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true,
                FirstName = "Default",
                LastName = "Admin",
                DateOfBirth = new DateOnly(1998,04,20)

            });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> 
                {
                    RoleId = "79411413-675d-40d4-93e5-afc5ea04fc06",
                    UserId = "fa556c12-0e07-4f3a-8487-4d422c590802"
                });
        }



        public DbSet<LeaveType> LeaveTypes { get; set; }
    }
}
