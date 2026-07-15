using Contract.Enum.EntityDomain;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Game.Response
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/game/response")]
#endif
    public class EntityActedDTO
    {
        public string EntityInstanceID { get; set; } = string.Empty;
        public float X { get; set; }
        public float Y { get; set; }
        public EntityDirection Direction { get; set; }
        public EntityAction Action { get; set; }
        public string? UsedItemDefinitionID { get; set; } = string.Empty;
    }
}