#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Runtime.MetaDomain
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/meta-domain")]
#endif
    public class EffectInstanceDTO
    {
        public string DefinitionID { get; set; } = string.Empty;
        public float? RemainingTime { get; set; }
        public float? IntervalDuration { get; set; }
        public float IntervalAccumulator { get; set; }
    }
}