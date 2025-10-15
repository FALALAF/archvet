using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.JSInterop;

namespace BlazorApp1.Services
{
    public class AuthStateService
    {
        private readonly IJSRuntime _jsRuntime;
        public event Action? OnChange;

        private string? _currentToken;
        private string? _userId;
        private string? _email;
        private string? _displayName;
        private bool _isAdmin;
        private bool _initialized = false;

        public bool IsAuthenticated => !string.IsNullOrEmpty(_currentToken);
        public string? DisplayName => _displayName;
        public string? Email => _email;
        public bool IsAdmin => _isAdmin;

        public AuthStateService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task InitializeAsync()
        {
            if (_initialized) return;

            try
            {
                var token = await _jsRuntime.InvokeAsync<string>("sessionStorage.getItem", "authToken");
                if (!string.IsNullOrEmpty(token))
                {
                    _currentToken = token;
                    ParseToken(token);
                }
            }
            catch { }

            _initialized = true;
        }

        public async Task SetAuthenticationAsync(string token)
        {
            _currentToken = token;
            ParseToken(token);

            try
            {
                await _jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "authToken", token);
            }
            catch { }

            NotifyStateChanged();
        }

        public async Task LogoutAsync()
        {
            _currentToken = null;
            _userId = null;
            _email = null;
            _displayName = null;
            _isAdmin = false;

            try
            {
                await _jsRuntime.InvokeVoidAsync("sessionStorage.removeItem", "authToken");
            }
            catch { }

            NotifyStateChanged();
        }

        private void ParseToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);

            _userId = jwtToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            _email = jwtToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            _displayName = jwtToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
            _isAdmin = jwtToken.Claims.Any(c => c.Type == ClaimTypes.Role && c.Value == "Admin");
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}