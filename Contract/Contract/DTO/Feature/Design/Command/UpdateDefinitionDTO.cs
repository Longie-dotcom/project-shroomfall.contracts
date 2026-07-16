#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Design.Command
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/design/command")]
#endif
    public class UpdateDefinitionDTO
    {
#if NET9_0
        [TsOptional]
#endif
        public string? Key { get; set; }
#if NET9_0
        [TsOptional]
#endif
        public string? Description { get; set; }
    }
}