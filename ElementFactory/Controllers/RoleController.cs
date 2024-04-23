using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ElementFactory.Data.Models;
using ElementFactory.Data;
using Microsoft.EntityFrameworkCore;
using ElementFactory.Core.Extensions;
using ElementFactory.Models.User;
namespace ElementFactory.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        private readonly UserManager<User> userManager;

        private readonly ApplicationDbContext context;

        public RoleController(RoleManager<IdentityRole> _roleManager,
            UserManager<User> _userManager,
            ApplicationDbContext context)
        {
            this.roleManager = _roleManager;
            this.userManager = _userManager;
            this.context = context;
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
            bool isAdminExists = await roleManager.RoleExistsAsync("Admin");
            bool isTeacherExists = await roleManager.RoleExistsAsync("Teacher");
            bool isStudentExists = await roleManager.RoleExistsAsync("Student");


            if (!isAdminExists
                && !isTeacherExists
                && !isStudentExists)
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
                await roleManager.CreateAsync(new IdentityRole("Teacher"));
                await roleManager.CreateAsync(new IdentityRole("Student"));
            }
            return RedirectToAction("SeedUsers");

        }

        public async Task<IActionResult> SeedUsers()
        {
            var school = await this.context.Schools.FirstAsync();

            if (await roleManager.RoleExistsAsync("Admin") &&
                userManager.GetUsersInRoleAsync("Admin").Result.Count == 0)
            {
                var admin1 = new User()
                {
                    Email = "rlgalexbgto@gamil.com",
                    UserName = "Alex",
                    IsActive = true,
                    Points = 100000,
                    School = school,
                    IsSchoolAccepted = true
                };

                var result1 = await userManager.CreateAsync(admin1, "Alex_Admin2007");

                var admin2 = new User()
                {
                    Email = "stilancanev@gamil.com",
                    UserName = "Stelko",
                    IsActive = true,
                    Points = 100000,
                    School = school,
                    IsSchoolAccepted = true
                };

                var result2 = await userManager.CreateAsync(admin2, "Stelko_Admin2007");


                var student1 = new User()
                {
                    Email = "studentTest1@gamil.com",
                    UserName = "Student1",
                    IsActive = true,
                    Points = 0,
                    School = school,
                    IsSchoolAccepted = true
                };
                var result3 = await userManager.CreateAsync(student1, "Test_Student2007");

                var student2 = new User()
                {
                    Email = "studentTest2@gamil.com",
                    UserName = "Student2",
                    IsActive = true,
                    Points = 0,
                    School = school,
                    IsSchoolAccepted = true
                };
                var result4 = await userManager.CreateAsync(student2, "Test_Student2007");

                var teacher1 = new User()
                {
                    Email = "teacherTest1@gamil.com",
                    UserName = "Teacher1",
                    IsActive = true,
                    Points = 0,
                    School = school,
                    IsSchoolAccepted = true
                };
                var result5 = await userManager.CreateAsync(teacher1, "Test_Teacher2007");

                var teacher2 = new User()
                {
                    Email = "teacherTest2@gamil.com",
                    UserName = "Teacher2",
                    IsActive = true,
                    Points = 0,
                    School = school,
                    IsSchoolAccepted = true
                };
                var result6 = await userManager.CreateAsync(teacher2, "Test_Teacher2007");


                var proPlayer1 = new User()
                {
                    Email = "proPlayer1@gamil.com",
                    UserName = "ProPlayer1",
                    IsActive = true,
                    Points = 200,
                    School = school,
                    IsSchoolAccepted = true
                };
                var result7 = await userManager.CreateAsync(proPlayer1, "Pro1_Player2007");

                var proPlayer2 = new User()
                {
                    Email = "proPlayer2@gamil.com",
                    UserName = "ProPlayer2",
                    IsActive = true,
                    Points = 100,
                    School = school,
                    IsSchoolAccepted = true
                };
                var result8 = await userManager.CreateAsync(proPlayer2, "Pro2_Player2007");

                if (result1.Succeeded && result2.Succeeded && result3.Succeeded && result4.Succeeded && result5.Succeeded && result6.Succeeded && result7.Succeeded && result8.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin1, "Admin");
                    await userManager.AddToRoleAsync(admin2, "Admin");

                    await userManager.AddToRoleAsync(student1, "Student");
                    await userManager.AddToRoleAsync(student2, "Student");

                    await userManager.AddToRoleAsync(teacher1, "Teacher");
                    await userManager.AddToRoleAsync(teacher2, "Teacher");

                    await userManager.AddToRoleAsync(proPlayer1, "Student");
                    await userManager.AddToRoleAsync(proPlayer2, "Student");
                }
            }

            return RedirectToAction("Welcome", "Home");

        }

        public async Task<IActionResult> SeeAllUsers()
        {
            var users = await GetAllUsers();
            return View(users);
        }

        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            user.IsActive = false;
            await userManager.UpdateAsync(user);
            var users = await GetAllUsers();
            return View("SeeAllUsers", users);
        }

        public async Task<IActionResult> RemoveTeacherRole(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            await userManager.RemoveFromRoleAsync(user, "Teacher");
            await userManager.AddToRoleAsync(user, "Student");
            await userManager.UpdateAsync(user);
            var users = await GetAllUsers();
            return View("SeeAllUsers", users);
        }

        public async Task<IActionResult> MakingATeacher(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            user.IsSchoolAccepted = true;
            await userManager.UpdateAsync(user);
            await userManager.AddToRoleAsync(user, "Teacher");
            await userManager.RemoveFromRoleAsync(user, "Student");
            user.IsRequested = false;
            await userManager.UpdateAsync(user);
            var users = await GetAllUsers();

            return View("SeeAllUsers", users);
        }

        public async Task<IActionResult> SeeAllStudents()
        {
            var userId = User.Id();

            var notValidatedStudents = await this.context.Users
                .Include(u => u.Teachers)
                .Include(u => u.Students)
                .Where(u => !u.Teachers.Any(t => t.Id == userId)).ToListAsync();

            var notValidatedStudentsList = new List<User>();

            for (int i = 0; i < notValidatedStudents.Count; i++)
            {
                var roles = await userManager.GetRolesAsync(notValidatedStudents[i]);
                if (!roles.Contains("Admin") && !roles.Contains("Teacher"))
                {
                    notValidatedStudentsList.Add(notValidatedStudents[i]);
                }
            }

            var validatedStudents = await this.context.Users
                 .Include(u => u.Teachers)
                .Include(u => u.Students)
                .Where(u => u.IsSchoolAccepted
            && u.Teachers.Any(t => t.Id == userId))
                .ToListAsync();

            var validatedStudentsList = new List<User>();

            for (int i = 0; i < validatedStudents.Count; i++)
            {
                var roles = await userManager.GetRolesAsync(validatedStudents[i]);
                if (!roles.Contains("Admin") && !roles.Contains("Teacher"))
                {
                    validatedStudentsList.Add(validatedStudents[i]);
                }
            }

            var viewModel = new StudentsViewModel()
            {
                MyStudents = validatedStudentsList.Select(s => new UserViewModel()
                {
                    Email = s.Email,
                    Id = s.Id,
                    PhoneNumber = s.Id,
                    UserName = s.UserName
                }).ToList(),
                OtherStudents = notValidatedStudentsList.Select(s => new UserViewModel()
                {
                    Email = s.Email,
                    Id = s.Id,
                    PhoneNumber = s.Id,
                    UserName = s.UserName
                }).ToList(),
            };

            return View(viewModel);
        }

        public async Task<IActionResult> SeeAllTeachers()
        {
            var userId = User.Id();

            var teachers = await this.context.Users
                .Include(u => u.Teachers)
                .Include(u => u.Students)
                .Where(u =>
                u.IsSchoolAccepted && u.Students.Any(s => s.Id == userId)).ToListAsync();

            var viewModel = new TeacherViewModel()
            {
                Teachers = teachers.Select(t => new UserViewModel
                {
                    Email = t.Email,
                    Id = t.Id,
                    PhoneNumber = t.PhoneNumber,
                    UserName = t.UserName
                }).ToList()
            };

            return View(viewModel);
        }

        public async Task<IActionResult> AddStudentToMyStudents(string studentId, string teacherId)
        {
            var teacherEntity = 
                await this.context.Users.Include(u => u.Teachers)
                .Include(u => u.Students).FirstOrDefaultAsync(t => t.Id == teacherId);

            var studentEntity =
                await this.context.Users.Include(u => u.Teachers)
                .Include(u => u.Students).FirstOrDefaultAsync(t => t.Id == studentId);

            if (teacherEntity == null || studentEntity == null)
            {
                return BadRequest();
            }

            studentEntity.IsSchoolAccepted = true;
            teacherEntity.Students.Add(studentEntity);
            studentEntity.Teachers.Add(teacherEntity);

            await this.context.SaveChangesAsync();

            return RedirectToAction("SeeAllStudents");
        }

        public async Task<IActionResult> RemoveStudentFromMyStudents(string studentId, string teacherId)
        {
            var teacherEntity =
               await this.context.Users.Include(u => u.Teachers)
                .Include(u => u.Students).FirstOrDefaultAsync(t => t.Id == teacherId);

            var studentEntity =
                await this.context.Users.Include(u => u.Teachers)
                .Include(u => u.Students).FirstOrDefaultAsync(t => t.Id == studentId);

            if (teacherEntity == null || studentEntity == null)
            {
                return BadRequest();
            }

            teacherEntity.Students.Remove(studentEntity);
            studentEntity.Teachers.Remove(teacherEntity);

            await this.context.SaveChangesAsync();

            return RedirectToAction("SeeAllStudents");
        }
    }
}
