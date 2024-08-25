using MemoryMagi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MemoryMagi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UsersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsersController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        [HttpGet("users")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userManager.Users.ToListAsync();
            var usersModeled = users.Select(user => new UserModel
            {
                UserId = user.Id,
                UserName = user.UserName,
                Email = user.Email
            }).ToList();

            return Ok(usersModeled);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound("User not found.");
            }

            var userDto = new UserModel
            {
                UserName = user.UserName,
                Email = user.Email
            };

            return Ok(userDto);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, true, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(model.UserName);

                return Ok(user!.Id);
            }
            return Unauthorized();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            //string specialTecken = "!@#$%^&*()_-+=<>?/";

            if (string.IsNullOrEmpty(model.Password) || model.Password.Length < 6)
            {
                return BadRequest("Lösenord ska ha minst 6 tecken");
            }

            if (!model.Password.Any(char.IsDigit))
            {
                return BadRequest("Lösenord måste innehålla minst 1 siffra");
            }

            if (!model.Password.Any(char.IsLower) || !model.Password.Any(char.IsUpper))
            {
                return BadRequest("Lösneord måste innehålla minst 1 stor och 1 liten bokstav");
            }

            if (!model.Password.Any(specialTecken => "!@#$%^&*()_-+=<>?/".Contains(specialTecken)))
            {
                return BadRequest("Lösenord måste innehålla ett special tecken");
            }

            if (!model.Email.Contains("@"))
            {
                return BadRequest("Email saknar '@' för att kunna slutföra registrering ");
            }


            var user = new ApplicationUser { UserName = model.UserName, Email = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                return Ok();
            }
            return BadRequest(result.Errors);
        }

        [HttpPut("update-user")]
        public async Task<IActionResult> UpdateUser([FromBody] UserModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            if (user == null)
            {
                return NotFound("User not found");
            }
            user.UserName = model.UserName;
            user.Email = model.Email;

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return Ok();
            }
            return BadRequest(result.Errors);
        }

        [HttpPut("update-password")]
        public async Task<IActionResult> UpdatePassword([FromBody] UpdatePasswordModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            if (user == null) return NotFound("User not found.");

            var result = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
            if (result.Succeeded)
            {
                return Ok();
            }
            return BadRequest(result.Errors);
        }

        // hehe

        public class RegisterModel
        {
            public string UserName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }

        public class LoginModel
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }

        public class UserModel
        {
            public string UserId { get; set; }
            public string UserName { get; set; }
            public string Email { get; set; }
        }
        public class UpdatePasswordModel
        {
            public string UserId { get; set; }
            public string CurrentPassword { get; set; }
            public string NewPassword { get; set; }
        }
    }
}
