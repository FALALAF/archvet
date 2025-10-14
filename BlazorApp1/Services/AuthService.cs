using BlazorApp1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BlazorApp1.Services
{
    public class AuthService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly string _jwtKey = "TwojaBardzoBezpiecznaTajnaKlucz12345!";

        public AuthService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<(bool Success, string Message, string? Token)> LoginAsync(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return (false, "Nieprawidłowy email lub hasło", null);

            var result = await _signInManager.CheckPasswordSignInAsync(user, password, false);
            if (!result.Succeeded)
                return (false, "Nieprawidłowy email lub hasło", null);

            var token = await GenerateJwtToken(user);
            return (true, "Zalogowano pomyślnie", token);
        }

        public async Task<(bool Success, string Message)> RegisterAsync(string email, string password, string displayName)
        {
            var existingUser = await _userManager.FindByEmailAsync(email);
            if (existingUser != null)
                return (false, "Użytkownik o tym emailu już istnieje");

            var user = new User
            {
                UserName = email,
                Email = email,
                DisplayName = displayName
            };

            var result = await _userManager.CreateAsync(user, password);
            if (!result.Succeeded)
                return (false, string.Join(", ", result.Errors.Select(e => e.Description)));

            return (true, "Rejestracja pomyślna! Możesz się teraz zalogować.");
        }

        public async Task<List<UserDto>> GetAllUsersAsync()
        {
            var users = _userManager.Users.ToList();
            var userDtos = new List<UserDto>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                userDtos.Add(new UserDto
                {
                    Id = user.Id,
                    Email = user.Email!,
                    DisplayName = user.DisplayName ?? "",
                    CreatedAt = user.CreatedAt,
                    IsAdmin = roles.Contains("Admin")
                });
            }

            return userDtos;
        }

        public async Task<(bool Success, string Message)> DeleteUserAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
                return (false, "Użytkownik nie istnieje");

            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
                return (true, "Użytkownik został usunięty");

            return (false, "Błąd podczas usuwania użytkownika");
        }

        public async Task<(bool Success, string Message)> ResetPasswordAsync(string userId, string newPassword)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
                return (false, "Użytkownik nie istnieje");

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, token, newPassword);

            if (result.Succeeded)
                return (true, "Hasło zostało zresetowane");

            return (false, string.Join(", ", result.Errors.Select(e => e.Description)));
        }

        private async Task<string> GenerateJwtToken(User user)
        {
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Email, user.Email!),
                new Claim(ClaimTypes.Name, user.DisplayName ?? user.Email!)
            };

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(7),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public class UserDto
        {
            public string Id { get; set; } = "";
            public string Email { get; set; } = "";
            public string DisplayName { get; set; } = "";
            public DateTime CreatedAt { get; set; }
            public bool IsAdmin { get; set; }
        }
    } // <-- To jest koniec klasy AuthService
}