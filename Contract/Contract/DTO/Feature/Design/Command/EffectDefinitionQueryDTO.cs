using Contract.Enum.MetaDomain.Effect;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Design.Command
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/design/command")]
#endif
    public class EffectDefinitionQueryDTO
    {
        public string? SearchTerm { get; set; }
        public EffectType? Type { get; set; }
        public AttributeType? AttributeType { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}