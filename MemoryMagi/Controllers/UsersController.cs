using MemoryMagi.Database;
using MemoryMagi.Models;
using MemoryMagi.Models._2._0;
using MemoryMagi.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MemoryMagi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UsersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly AppDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly GenericRepository<AchievementModel> AchievementRepo;

        public UsersController(AppDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _context = context;
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

        [HttpGet("user")]
        public async Task<IActionResult> GetUser()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(userId))
            {
                return BadRequest("User information is missing from the token.");
            }

            // Eagerly load UserAchievements and related Achievements
            var user = await _userManager.Users
                .Include(u => u.UserAchievements)
                    .ThenInclude(ua => ua.Achievement)  // Include Achievement details
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
            {
                return NotFound("User not found.");
            }

            // Mapping the UserAchievements to a simplified DTO
            var userAchievementsDto = user.UserAchievements.Select(ua => new
            {
                AchievementId = ua.AchievementId,
                Name = ua.Achievement?.Name, // Ensure we only get Name if Achievement is not null
                Description = ua.Achievement?.Description,
                AchievementDate = ua.AchievementDate.ToString("yyyy-MM-dd") // Format date as string
            }).ToList();

            // Creating the final userDto
            var userDto = new
            {
                UserId = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                Achievements = userAchievementsDto
            };

            return Ok(userDto);
        }


        //[HttpPost("login")]
        //public async Task<IActionResult> Login([FromBody] LoginModel model)
        //{
        //    var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, true, lockoutOnFailure: false);
        //    if (result.Succeeded)
        //    {
        //        var user = await _userManager.FindByNameAsync(model.UserName);

        //        return Ok(user!.Id);
        //    }
        //    return Unauthorized();
        //}

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
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);

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
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return NotFound("User not found.");
            }

            var result = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
            if (result.Succeeded)
            {
                return Ok();
            }
            return BadRequest("Current password incorrect." + result.Errors);
        }

        [HttpPut("update-achievements")]
        public async Task<IActionResult> UpdateAchievements([FromBody] List<AchievementDto> updatedAchievements)
        {
            // Retrieve user ID from the token
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(userId))
            {
                return BadRequest("User information is missing from the token.");
            }

            // Fetch the current user and their achievements
            var user = await _userManager.Users
                .Include(u => u.UserAchievements) // Include achievements
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
            {
                return NotFound("User not found.");
            }

            // Loop through the updated achievements and apply changes
            foreach (var achievementDto in updatedAchievements)
            {
                var existingAchievement = user.UserAchievements
                    .FirstOrDefault(ua => ua.AchievementId == achievementDto.AchievementId);

                if (existingAchievement != null)
                {
                    // Update the date of the existing achievement
                    existingAchievement.AchievementDate = DateOnly.Parse(achievementDto.AchievementDate);
                }
                else
                {
                    // Add a new achievement to the user
                    user.UserAchievements.Add(new UserAchievement
                    {
                        UserId = userId,
                        AchievementId = achievementDto.AchievementId,
                        AchievementDate = DateOnly.Parse(achievementDto.AchievementDate),
                    });
                }
            }

            try
            {
                // Save the changes to the database
                var result = await _userManager.UpdateAsync(user);
                if (!result.Succeeded)
                {
                    return StatusCode(500, "Error updating achievements.");
                }

                // Optionally, return the updated user to the client
                var updatedUser = await _userManager.Users
                    .Include(u => u.UserAchievements)
                    .FirstOrDefaultAsync(u => u.Id == userId);

                return Ok(updatedUser);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
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
            public string CurrentPassword { get; set; }
            public string NewPassword { get; set; }
        }
        public class AchievementDto
        {
            public int AchievementId { get; set; }
            public string AchievementDate { get; set; } // Date in string format ("yyyy-MM-dd")
        }
    }
}
