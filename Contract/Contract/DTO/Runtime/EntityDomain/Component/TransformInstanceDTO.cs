using Contract.DTO.Abstraction;
using Contract.DTO.Common;
using Contract.Enum.EntityDomain;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Runtime.EntityDomain.Component
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/entity-domain/component")]
#endif
    public class TransformInstanceDTO : ComponentInstanceDTO
    {
        public int LayerZ { get; set; }
        public Vector2DTO Position { get; set; } = new Vector2DTO();
        public EntityDirection FacingDirection { get; set; }
        public EntityAction CurrentAction { get; set; }
    }
}