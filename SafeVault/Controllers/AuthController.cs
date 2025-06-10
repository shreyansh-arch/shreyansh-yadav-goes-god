using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase {
    private readonly AuthService _authService;

    public AuthController(AuthService authService) {
        _authService = authService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromForm] string username, [FromForm] string password) {
        // Simulate secure user retrieval (parameterized query assumed here)
        var user = GetUserFromDatabase(username); // placeholder method

        if (user != null && _authService.Authenticate(password, user.PasswordHash)) {
            return Ok($"Welcome, {user.Username}");
        }

        return Unauthorized();
    }

    private User GetUserFromDatabase(string username) {
        // In real code, query DB with parameterized statements
        return new User {
            Username = username,
            PasswordHash = _authService.HashPassword("securePassword123"),
            Role = "admin"
        };
    }
}
