#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif
using Contract.Enum.EntityDomain;

namespace Contract.DTO.Feature.Design.Command
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/design/command")]
#endif
    public class EntityDefinitionQueryDTO
    {
#if NET9_0
        [TsIgnore]
#endif
        public string? SearchTerm { get; set; }
#if NET9_0
        [TsIgnore]
#endif
        public EntityType? EntityType { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}