using Contract.DTO.Abstraction;
using Contract.DTO.Common;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Runtime.EntityDomain.Component
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/entity-domain/component")]
#endif
    public class ProjectileInstanceDTO : ComponentInstanceDTO
    {
        public float Velocity { get; set; }
        public Vector2DTO Direction { get; set; } = new Vector2DTO();
    }
}