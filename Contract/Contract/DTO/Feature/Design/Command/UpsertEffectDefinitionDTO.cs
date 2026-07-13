using Contract.Enum.MetaDomain.Effect;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Design.Command
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/design/command")]
#endif
    public class UpsertEffectDefinitionDTO
    {
        public string Id { get; set; } = string.Empty;
        public EffectType Type { get; set; }
        public AttributeType AttributeType { get; set; }
#if NET9_0
        [TsOptional]
#endif
        public AttributeType? SourceType { get; set; }
        public float Value { get; set; }
#if NET9_0
        [TsOptional]
#endif
        public float? Duration { get; set; }
#if NET9_0
        [TsOptional]
#endif
        public float? Interval { get; set; }
    }
}