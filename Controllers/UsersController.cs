using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UserManagementAPI.Models.Dtos;
using UserManagementAPI.Services;

namespace UserManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(UserService userService, IConfiguration configuration) : ControllerBase
    {
        private readonly UserService _userService = userService;
        private readonly string _jwtSecret = configuration["JwtSettings:Secret"];

        [Authorize]
        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAllUsers()
        {
            var allUsers = await _userService.GetAllUsersAsync();

            var users = allUsers.Select(user => new UserDto
            {
                Id = user.Id,
                Email = user.Email,
                Username = user.Username,
                CreatedAt = user.CreatedAt,
                UpdatedAt = user.UpdatedAt
            });

            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserDto addUserDto)
        {
            var existingUser = await _userService.GetUserByEmailAsync(addUserDto.Email);
            if (existingUser != null)
            {
                return BadRequest("Email already exists.");
            }

            var addedUser = await _userService.AddUserAsync(addUserDto);

            var user = new UserDto
            {
                Id = addedUser.Id,
                Email = addedUser.Email,
                Username = addedUser.Username,
                CreatedAt = addedUser.CreatedAt,
                UpdatedAt = addedUser.UpdatedAt
            };

            return Ok(user);
        }
    }
}
