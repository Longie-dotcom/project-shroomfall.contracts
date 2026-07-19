using System;
#if NET9_0
using Contract.DTO.Runtime.EntityDomain.Component;
using System.Text.Json.Serialization;
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Abstraction
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/abstraction")]
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "ComponentType")]
    [JsonDerivedType(typeof(ActionInstanceDTO), typeDiscriminator: "ActionInstanceDTO")]
    [JsonDerivedType(typeof(AIInstanceDTO), typeDiscriminator: "AIInstanceDTO")]
    [JsonDerivedType(typeof(AppearanceInstanceDTO), typeDiscriminator: "AppearanceInstanceDTO")]
    [JsonDerivedType(typeof(CollisionInstanceDTO), typeDiscriminator: "CollisionInstanceDTO")]
    [JsonDerivedType(typeof(CharacteristicInstanceDTO), typeDiscriminator: "CharacteristicInstanceDTO")]
    [JsonDerivedType(typeof(EffectContainerInstanceDTO), typeDiscriminator: "EffectContainerInstanceDTO")]
    [JsonDerivedType(typeof(InventoryInstanceDTO), typeDiscriminator: "InventoryInstanceDTO")]
    [JsonDerivedType(typeof(LifetimeInstanceDTO), typeDiscriminator: "LifetimeInstanceDTO")]
    [JsonDerivedType(typeof(OwnershipInstanceDTO), typeDiscriminator: "OwnershipInstanceDTO")]
    [JsonDerivedType(typeof(ProjectileInstanceDTO), typeDiscriminator: "ProjectileInstanceDTO")]
    [JsonDerivedType(typeof(TransformInstanceDTO), typeDiscriminator: "TransformInstanceDTO")]
    [JsonDerivedType(typeof(TriggeredEffectInstanceDTO), typeDiscriminator: "TriggeredEffectInstanceDTO")]
    [JsonDerivedType(typeof(WorldItemPayloadInstanceDTO), typeDiscriminator: "WorldItemPayloadInstanceDTO")]
#endif
    public class ComponentInstanceDTO
    {
        public Guid DefinitionID { get; set; }
    }
}