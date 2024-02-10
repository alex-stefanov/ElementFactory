using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ElementFactory.Data.Models;
namespace ElementFactory.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        private readonly UserManager<User> userManager;

        public RoleController(RoleManager<IdentityRole> _roleManager,
            UserManager<User> _userManager)
        {
            this.roleManager = _roleManager;
            this.userManager = _userManager;
        }

        private async Task<List<User>> GetAllUsers()
        {
            var students = await userManager.GetUsersInRoleAsync("Student");

            var teachers = await userManager.GetUsersInRoleAsync("Teacher");

            var users = new List<User>();

            users.AddRange(students.Where(x => x.IsActive));
            users.AddRange(teachers.Where(x => x.IsActive));

            return users;
        }

        public async Task<IActionResult> CreateRoles()
        {
            if(!await roleManager.RoleExistsAsync("Admin")
                && !await roleManager.RoleExistsAsync("Teacher")
                && !await roleManager.RoleExistsAsync("Student"))
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
                await roleManager.CreateAsync(new IdentityRole("Teacher"));
                await roleManager.CreateAsync(new IdentityRole("Student"));
            }
            return RedirectToAction("SeedAdmins");
            
        }

        public async Task<IActionResult> SeedAdmins()
        {
            if (await roleManager.RoleExistsAsync("Admin") &&
                userManager.GetUsersInRoleAsync("Admin").Result.Count == 0)
            {
                var admin1 = new User()
                {
                    Email = "rlgalexbgto@gamil.com",
                    UserName = "Alex"
                };

                var result1 = await userManager.CreateAsync(admin1, "Alex_Admin2007");

                var admin2 = new User()
                {
                    Email = "stilancanev@gamil.com",
                    UserName = "Stelko"
                };

                var result2 = await userManager.CreateAsync(admin2, "Stelko_Admin2007");

                if (result1.Succeeded && result2.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin1, "Admin");
                    await userManager.AddToRoleAsync(admin2, "Admin");
                }
            }
            return RedirectToAction("Welcome", "Home");

        }

        public async Task<IActionResult> SeeAllUsers()
        {
            var users= await GetAllUsers();
            return View(users);
        }

        public async Task<IActionResult> DeleteUser(string id)
        {
            var user= await userManager.FindByIdAsync(id);
            user.IsActive = false;
            await userManager.UpdateAsync(user);
            var users=await GetAllUsers();
            return View("SeeAllUsers", users);
        }

        public async Task<IActionResult> RemoveTeacherRole(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            await userManager.RemoveFromRoleAsync(user,"Teacher");
            await userManager.UpdateAsync(user);
            await userManager.AddToRoleAsync(user, "Student");
            await userManager.UpdateAsync(user);
            var users=await GetAllUsers();
            return View("SeeAllUsers",users);
        }

        public async Task<IActionResult> MakingATeacher(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            await userManager.AddToRoleAsync(user, "Teacher");
            await userManager.UpdateAsync(user);
            await userManager.RemoveFromRoleAsync(user, "Student");
            await userManager.UpdateAsync(user);
            var users = await GetAllUsers();
            return View("SeeAllUsers", users);
        }

    }
}
