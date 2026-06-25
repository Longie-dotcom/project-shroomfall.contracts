using Contract.DTO.Common;
using Contract.Enum.EntityDomain;
using Contract.Enum.MetaDomain.Effect;
using Contract.Enum.MetaDomain.Item;
using System;
using System.Collections.Generic;

#if NET9_0
using TypeGen.Core.TypeAnnotations;
using System.Text.Json.Serialization;
#endif

namespace Contract.DTO.Domain.Definition
{
#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class EntityDefinitionDetailDTO
    {
        public string ID { get; set; } = string.Empty;
        public EntityType Type { get; set; }
        public EntityPresentationDefinitionDTO Presentation { get; set; } = new EntityPresentationDefinitionDTO();
        public List<ComponentDefinitionDTO> Components { get; set; } = new List<ComponentDefinitionDTO>();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class EntityDefinitionDTO
    {
        public string ID { get; set; } = string.Empty;
        public EntityType Type { get; set; }
        public EntityPresentationDefinitionDTO Presentation { get; set; } = new EntityPresentationDefinitionDTO();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class EntityPresentationDefinitionDTO
    {
        public LocalizedTextDTO LocalizedText { get; set; } = new LocalizedTextDTO();
        public string? IconID { get; set; } = string.Empty;
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "ComponentType")]
    [JsonDerivedType(typeof(AIDefinitionDTO), typeDiscriminator: "AIDefinitionDTO")]
    [JsonDerivedType(typeof(AppearanceDefinitionDTO), typeDiscriminator: "AppearanceDefinitionDTO")]
    [JsonDerivedType(typeof(CollisionDefinitionDTO), typeDiscriminator: "CollisionDefinitionDTO")]
    [JsonDerivedType(typeof(CharacteristicDefinitionDTO), typeDiscriminator: "CharacteristicDefinitionDTO")]
    [JsonDerivedType(typeof(InteractableDefinitionDTO), typeDiscriminator: "InteractableDefinitionDTO")]
    [JsonDerivedType(typeof(InventoryDefinitionDTO), typeDiscriminator: "InventoryDefinitionDTO")]
    [JsonDerivedType(typeof(LifetimeDefinitionDTO), typeDiscriminator: "LifetimeDefinitionDTO")]
    [JsonDerivedType(typeof(PortalDefinitionDTO), typeDiscriminator: "PortalDefinitionDTO")]
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

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class AIDefinitionDTO : ComponentDefinitionDTO
    {
        public AIDefinitionDTO() { ComponentType = nameof(AIDefinitionDTO); }

        public float LeashDistance { get; set; }
        public float AggroRadius { get; set; }
        public float ThinkInterval { get; set; }
        public bool IsAIControlled { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class AppearanceDefinitionDTO : ComponentDefinitionDTO
    {
        public AppearanceDefinitionDTO() { ComponentType = nameof(AppearanceDefinitionDTO); }

        public string SkinID { get; set; } = string.Empty;
        public HSVDTO SkinColor { get; set; } = new  HSVDTO();
#if NET9_0
        [TsOptional]
#endif
        public string? HairID { get; set; }
#if NET9_0
        [TsOptional]
#endif
        public string? EyesID { get; set; }
#if NET9_0
        [TsOptional]
#endif
        public string? ShirtID { get; set; }
#if NET9_0
        [TsOptional]
#endif
        public string? PantID { get; set; }
        public HSVDTO HairColor { get; set; } = new HSVDTO();
        public HSVDTO PantColor { get; set; } = new HSVDTO();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class CollisionDefinitionDTO : ComponentDefinitionDTO
    {
        public CollisionDefinitionDTO() { ComponentType = nameof(CollisionDefinitionDTO); }

        public CollisionShapeType ShapeType { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Radius { get; set; }
        public bool IsBlocking { get; set; }
        public CollisionLayer Layer { get; set; }
        public CollisionLayer Mask { get; set; }
        public float OffsetX { get; set; }
        public float OffsetY { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class CharacteristicDefinitionDTO : ComponentDefinitionDTO
    {
        public CharacteristicDefinitionDTO() { ComponentType = nameof(CharacteristicDefinitionDTO); }

        public List<AttributeValueDTO> AttributeValues { get; set; } = new List<AttributeValueDTO>();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class AttributeValueDTO
    {
#if NET9_0
        [TsOptional]
#endif
        public Guid? ID { get; set; }
        public AttributeType Type { get; set; }
        public float BaseValue { get; set; }
        public int Level { get; set; }
        public float Min { get; set; }
        public float Max { get; set; }
        public List<AttributeGrowthValueDTO> AttributeGrowthValues { get; set; } = new List<AttributeGrowthValueDTO>();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class AttributeGrowthValueDTO
    {
#if NET9_0
        [TsOptional]
#endif
        public Guid? ID { get; set; }
        public int Level { get; set; }
        public float GrowthValue { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class InteractableDefinitionDTO : ComponentDefinitionDTO
    {
        public InteractableDefinitionDTO() { ComponentType = nameof(InteractableDefinitionDTO); }

        public WorldObjectInteractionType Type { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class InventoryDefinitionDTO : ComponentDefinitionDTO
    {
        public InventoryDefinitionDTO() { ComponentType = nameof(InventoryDefinitionDTO); }

        public int SlotCount { get; set; }
        public List<InventoryEntryDTO> DefaultItems { get; set; } = new List<InventoryEntryDTO>();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class InventoryEntryDTO
    {
#if NET9_0
        [TsOptional]
#endif
        public Guid? ID { get; set; }
        public string DefinitionID { get; set; } = string.Empty;
        public int Amount { get; set; }
        public ItemQuality Quality { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class LifetimeDefinitionDTO : ComponentDefinitionDTO
    {
        public LifetimeDefinitionDTO() { ComponentType = nameof(LifetimeDefinitionDTO); }

        public float Lifetime { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class PortalDefinitionDTO : ComponentDefinitionDTO
    {
        public PortalDefinitionDTO() { ComponentType = nameof(PortalDefinitionDTO); }

        public float LocalTriggerOffsetX { get; set; }
        public float LocalTriggerOffsetY { get; set; }
        public float TriggerWidth { get; set; }
        public float TriggerHeight { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class ProjectileDefinitionDTO : ComponentDefinitionDTO
    {
        public ProjectileDefinitionDTO() { ComponentType = nameof(ProjectileDefinitionDTO); }

        public float Velocity { get; set; }
        public string? OnImpactSpawnEntityDefinitionID { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class TriggeredEffectDefinitionDTO : ComponentDefinitionDTO
    {
        public TriggeredEffectDefinitionDTO() { ComponentType = nameof(TriggeredEffectDefinitionDTO); }

        public List<string> EffectDefinitionIDs { get; set; } = new List<string>();
    }
}