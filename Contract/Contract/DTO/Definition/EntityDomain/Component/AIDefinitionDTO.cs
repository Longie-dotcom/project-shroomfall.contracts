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
    [EntityComponent(EntityType.Creature, Required = true)]
    public class AIDefinitionDTO : ComponentDefinitionDTO
    {
        public AIDefinitionDTO() { ComponentType = nameof(AIDefinitionDTO); }

        public float LeashDistance { get; set; }
        public float AggroRadius { get; set; }
        public float ThinkInterval { get; set; }
        public bool IsAIControlled { get; set; }
        public string EquippedItemDefinitionID { get; set; } = string.Empty;
        public float AttackRange { get; set; }
    }
}