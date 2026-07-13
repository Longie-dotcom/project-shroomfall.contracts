using Contract.DTO.Definition.LocalizationDomain;
using Contract.Enum.MetaDomain.Effect;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Definition.MetaDomain
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/meta-domain")]
#endif
    public class EffectDefinitionDTO
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
#if NET9_0
        [TsOptional]
#endif
        public EffectPresentationDefinitionDTO Presentation { get; set; } = new EffectPresentationDefinitionDTO();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/meta-domain")]
#endif
    public class EffectPresentationDefinitionDTO
    {
        public LocalizedTextDTO LocalizedText { get; set; } = new LocalizedTextDTO();
#if NET9_0
        [TsOptional]
#endif
        public string? IconID { get; set; } = string.Empty;
    }
}