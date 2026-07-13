using System;
#if NET9_0
using Contract.DTO.Definition.EntityDomain.Component;
using System.Text.Json.Serialization;
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Abstraction
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/abstraction")]
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "ComponentType")]
    [JsonDerivedType(typeof(AIDefinitionDTO), typeDiscriminator: "AIDefinitionDTO")]
    [JsonDerivedType(typeof(AppearanceDefinitionDTO), typeDiscriminator: "AppearanceDefinitionDTO")]
    [JsonDerivedType(typeof(CollisionDefinitionDTO), typeDiscriminator: "CollisionDefinitionDTO")]
    [JsonDerivedType(typeof(CharacteristicDefinitionDTO), typeDiscriminator: "CharacteristicDefinitionDTO")]
    [JsonDerivedType(typeof(InventoryDefinitionDTO), typeDiscriminator: "InventoryDefinitionDTO")]
    [JsonDerivedType(typeof(LifetimeDefinitionDTO), typeDiscriminator: "LifetimeDefinitionDTO")]
    [JsonDerivedType(typeof(ProjectileDefinitionDTO), typeDiscriminator: "ProjectileDefinitionDTO")]
    [JsonDerivedType(typeof(TriggeredEffectDefinitionDTO), typeDiscriminator: "TriggeredEffectDefinitionDTO")]
#endif
    public class ComponentDefinitionDTO
    {
#if NET9_0
        [TsOptional]
#endif
        public Guid? ID { get; set; }
        public string EntityDefinitionID { get; set; } = string.Empty;
        public string ComponentType { get; set; } = string.Empty;
    }
}