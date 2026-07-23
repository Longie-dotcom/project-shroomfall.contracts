using Contract.Attributes;
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
    [EntityComponent(EntityType.Projectile, Required = true)]
    public class ProjectileDefinitionDTO : ComponentDefinitionDTO
    {
        public ProjectileDefinitionDTO() { ComponentType = nameof(ProjectileDefinitionDTO); }

        public float Velocity { get; set; }
        public string? OnImpactSpawnEntityDefinitionID { get; set; }
    }
}