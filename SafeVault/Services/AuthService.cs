using System.Security.Cryptography;
using System.Text;

public class AuthService {
    public bool Authenticate(string inputPassword, string storedHash) {
        return BCrypt.Net.BCrypt.Verify(inputPassword, storedHash);
    }

    public string HashPassword(string password) {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }
}
