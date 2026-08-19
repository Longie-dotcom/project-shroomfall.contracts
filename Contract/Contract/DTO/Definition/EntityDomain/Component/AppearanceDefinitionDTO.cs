using Contract.Attributes;
using Contract.Common;
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
    [EntityComponent(EntityType.Creature, EntityType.Player, EntityType.Projectile, EntityType.WorldObject, Required = true)]
    public class AppearanceDefinitionDTO : ComponentDefinitionDTO
    {
        public AppearanceDefinitionDTO() { ComponentType = nameof(AppearanceDefinitionDTO); }

#if NET9_0
        [TsIgnore]
#endif
        public string? SkinID { get; set; } = string.Empty;
        public HSV SkinColor { get; set; } = new HSV();
    }
}