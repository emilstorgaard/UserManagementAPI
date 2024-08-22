namespace UserManagementAPI.Services
{
    public interface IAuthService
    {
        bool VerifyPassword(string password, string storedHash);
    }
}