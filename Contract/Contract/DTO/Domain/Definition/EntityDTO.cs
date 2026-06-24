using Contract.DTO.Common;
using Contract.Enum.EntityDomain;
using System;
using System.Collections.Generic;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Domain.Definition
{
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
#endif
    public class ComponentDefinitionDTO
    {
        public Guid? ID { get; set; }
        public string EntityDefinitionID { get; set; } = string.Empty;
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class AIDefinitionDTO : ComponentDefinitionDTO
    {
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
        public string SkinID { get; set; } = string.Empty;
        public HSVDTO SkinColor { get; set; } = new  HSVDTO();
        public string? HairID { get; set; }
        public string? EyesID { get; set; }
        public string? ShirtID { get; set; }
        public string? PantID { get; set; }
        public HSVDTO HairColor { get; set; } = new HSVDTO();
        public HSVDTO PantColor { get; set; } = new HSVDTO();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class CollisionDefinitionDTO : ComponentDefinitionDTO
    {
        public string ShapeType { get; set; } = string.Empty; // Maps string-converted enums cleanly
        public float Width { get; set; }
        public float Height { get; set; }
        public float Radius { get; set; }
        public bool IsBlocking { get; set; }
        public string Layer { get; set; } = string.Empty;
        public string Mask { get; set; } = string.Empty;
        public float OffsetX { get; set; }
        public float OffsetY { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class CharacteristicDefinitionDTO : ComponentDefinitionDTO
    {
        public List<AttributeValueDTO> AttributeValues { get; set; } = new List<AttributeValueDTO>();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class AttributeValueDTO
    {
        public Guid ID { get; set; }
        public string Type { get; set; } = string.Empty;
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
        public Guid ID { get; set; }
        public int Level { get; set; }
        public float GrowthValue { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class InteractableDefinitionDTO : ComponentDefinitionDTO
    {
        public WorldObjectInteractionType Type { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class InventoryDefinitionDTO : ComponentDefinitionDTO
    {
        public int SlotCount { get; set; }
        public List<InventoryEntryDTO> DefaultItems { get; set; } = new List<InventoryEntryDTO>();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class InventoryEntryDTO
    {
        public Guid ID { get; set; }
        public string DefinitionID { get; set; } = string.Empty;
        public int Amount { get; set; }
        public string Quality { get; set; } = string.Empty;
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class LifetimeDefinitionDTO : ComponentDefinitionDTO
    {
        public float Lifetime { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class PortalDefinitionDTO : ComponentDefinitionDTO
    {
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
        public float Velocity { get; set; }
        public string? OnImpactSpawnEntityDefinitionID { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/entity")]
#endif
    public class TriggeredEffectDefinitionDTO : ComponentDefinitionDTO
    {
        public List<string> EffectDefinitionIDs { get; set; } = new List<string>();
    }
}