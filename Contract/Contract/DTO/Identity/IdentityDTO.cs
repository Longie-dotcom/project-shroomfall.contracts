using Contract.Enum.IdentityDomain;
using System;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Identity
{
#if NET9_0
    [ExportTsInterface(OutputDir = "identity/responses")]
#endif
    public class UserDTO
    {
        public string ID { get; set; } = string.Empty;
        public Role Role { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime? Dob { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public string? SteamID { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiry { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastLogin { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "identity/responses")]
#endif
    public class TokenDTO
    {
        public string AccessToken { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
    }
}