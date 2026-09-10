#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif
using System;

namespace Contract.DTO.Feature.Identity.Response
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/identity/response")]
#endif
    public class TokenDTO
    {
        public string AccessToken { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime AccessExpiry { get; set; }
        public DateTime RefreshExpiry { get; set; }
    }
}