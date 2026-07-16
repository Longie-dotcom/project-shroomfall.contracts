using Contract.DTO.Abstraction;
using Contract.Enum.EntityDomain;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Definition.EntityDomain.Component
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/entity-domain/component")]
#endif
    public class CollisionDefinitionDTO : ComponentDefinitionDTO
    {
        public CollisionDefinitionDTO() { ComponentType = nameof(CollisionDefinitionDTO); }

#if NET9_0
        [TsIgnore]
#endif
        public CollisionRole? CollisionRole { get; set; }

        public CollisionShapeType ShapeType { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Radius { get; set; }
        public bool IsBlocking { get; set; }
#if NET9_0
        [TsIgnore]
#endif
        public CollisionLayer Layer { get; set; }
#if NET9_0
        [TsIgnore]
#endif
        public CollisionLayer Mask { get; set; }
        public float OffsetX { get; set; }
        public float OffsetY { get; set; }
    }
}