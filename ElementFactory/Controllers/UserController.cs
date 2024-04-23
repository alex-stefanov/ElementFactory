namespace ElementFactory.Controllers
{
    using ElementFactory.Data;
    using ElementFactory.Data.Models;
    using ElementFactory.Models.Login;
    using ElementFactory.Models.Register;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    [Authorize]
    public class UserController : Controller
    {
        private readonly UserManager<User> userManager;

        private readonly SignInManager<User> signInManager;

        private readonly ApplicationDbContext context;

        public UserController(
            UserManager<User> _userManager,
            SignInManager<User> _signInManager,
            ApplicationDbContext context)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            this.context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            var model = new RegisterViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var school = await this.context.Schools.FindAsync(model.SchoolId);

            var user = new User()
            {
                Email = model.Email,
                UserName = model.UserName,
                IsActive = true,
                IsRequested = false,
                Points = 0,
                School = school
            };

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "Student");
                return RedirectToAction("Login", "User");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }

            return View(model);
        }

       
        
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            var model = new LoginViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await userManager.FindByNameAsync(model.UserName);

            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Welcome", "Home");
                }
            }
            ModelState.AddModelError("", "Invalid login");
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Login", "User");
        }

        public async Task<IActionResult> LoadProfile(string id)
        {
            var user = await this.context.Users
                .Include(u => u.School)
                .Include(u => u.Teachers)
                .Include(u => u.Students)
                .FirstOrDefaultAsync(t => t.Id == id);

            if (user == null)
            {
                return BadRequest();
            }

            return View(user);
        }
    }
}