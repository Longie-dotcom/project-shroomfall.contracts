using Contract.DTO.Common;
using Contract.DTO.Runtime.EntityDomain;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Game.Response
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/game/response")]
#endif
    public class EntitySpawnedDTO
    {
        public EntityInstanceDTO EntityInstance { get; set; } = new EntityInstanceDTO();
        public Vector2DTO? Direction { get; set; } 
    }
}
