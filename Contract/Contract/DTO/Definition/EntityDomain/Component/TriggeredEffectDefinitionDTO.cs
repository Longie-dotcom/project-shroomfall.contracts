using Contract.Attributes;
using Contract.DTO.Abstraction;
using Contract.Enum.EntityDomain;
using System.Collections.Generic;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Definition.EntityDomain.Component
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/entity-domain/component")]
#endif
    [EntityComponent(EntityType.Projectile, Required = true)]
    public class TriggeredEffectDefinitionDTO : ComponentDefinitionDTO
    {
        public TriggeredEffectDefinitionDTO() { ComponentType = nameof(TriggeredEffectDefinitionDTO); }

        public List<string> EffectDefinitionIDs { get; set; } = new List<string>();
    }
}