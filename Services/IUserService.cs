using UserManagementAPI.Models.Dtos;
using UserManagementAPI.Models.Entities;

namespace UserManagementAPI.Services
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsersAsync();
        Task<User?> GetUserByEmailAsync(string email);
        Task<User> AddUserAsync(AddUserDto addUserDto);
    }
}