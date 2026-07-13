#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Identity.Response
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/identity/response")]
#endif
    public class TokenDTO
    {
        public string AccessToken { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
    }
}