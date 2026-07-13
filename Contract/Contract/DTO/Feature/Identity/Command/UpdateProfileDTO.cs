using System;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Identity.Command
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/identity/command")]
#endif
    public class UpdateProfileDTO
    {
        public string? Name { get; set; } = string.Empty;
        public string? Gender { get; set; } = string.Empty;
        public DateTime? Dob { get; set; }
    }
}