using Contract.Enum.MetaDomain.Effect;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Game.Response
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/game/response")]
#endif
    public class EntityVitalChangedDTO
    {
        public string EntityInstanceID { get; set; } = string.Empty;
        public AttributeType AttributeType { get; set; }
        public float NewValue { get; set; }
        public VitalChangeReason VitalChangeReason { get; set; }
    }
}