namespace UserManagementAPI.Services
{
    public class AuthService : IAuthService
    {
        public bool VerifyPassword(string password, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, storedHash);
        }
    }
}
