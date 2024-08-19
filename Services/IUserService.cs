using UserManagementAPI.Models.Entities;

namespace UserManagementAPI.Services
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsersAsync();
    }
}