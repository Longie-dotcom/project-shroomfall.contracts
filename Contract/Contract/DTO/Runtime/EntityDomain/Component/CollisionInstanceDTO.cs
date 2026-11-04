using Contract.Common;
using Contract.DTO.Abstraction;
using Contract.Enum.EntityDomain;

#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Runtime.EntityDomain.Component
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/entity-domain/component")]
#endif
    public class CollisionInstanceDTO : ComponentInstanceDTO
    {
        public CollisionShapeType ShapeType { get; set; }
        public Vector2 CollisionOffset { get; set; } = new Vector2();
        public CollisionLayer Layer { get; set; }
        public CollisionLayer Mask { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Radius { get; set; }
        public bool IsBlocking { get; set; }
    }
}