#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Identity.Command
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/identity/command")]
#endif
    public class RefreshTokenDTO
    {
        public string RefreshToken { get; set; } = string.Empty;
    }
}