using Contract.DTO.Common;
using Contract.Enum.EntityDomain;
using Contract.Enum.MetaDomain.Effect;
using Contract.Enum.MetaDomain.Item;
using System;
using System.Collections.Generic;

namespace Contract.DTO.Domain.Runtime
{
    public class EntityInstanceDTO
    {
        public string ID { get; set; } = string.Empty;
        public string DefinitionID { get; set; } = string.Empty;
        public List<ComponentInstanceDTO> Components { get; set; } = new List<ComponentInstanceDTO>();
    }

    public class ComponentInstanceDTO
    {
        public Guid DefinitionID { get; set; }
    }

    public class ActionInstanceDTO : ComponentInstanceDTO
    {

    }

    public class AIInstanceDTO : ComponentInstanceDTO
    {
        public AIState AIState { get; set; } = AIState.Idle;
        public string? TargetEntityId { get; set; }
        public bool IsAIControlled { get; set; } = true;
        public float ThinkCooldownRemaining { get; set; }
        public float AttackTimer { get; set; }
        public float LeashDistance { get; set; } = 10.0f;
        public float AggroRadius { get; set; } = 5.0f;
    }

    public class AppearanceInstanceDTO : ComponentInstanceDTO
    {
        public string SkinID { get; set; } = string.Empty;
        public HSVDTO SkinColor { get; set; } = new HSVDTO();
    }

    public class CharacteristicInstanceDTO : ComponentInstanceDTO
    {
        public List<AttributeValueInstanceDTO> Cores { get; set; } = new List<AttributeValueInstanceDTO>();
        public List<AttributeValueInstanceDTO> Vitals { get; set; } = new List<AttributeValueInstanceDTO>();
    }

    public class AttributeValueInstanceDTO
    {
        public AttributeType AttributeType { get; set; }
        public float Value { get; set; }
    }

    public class EffectContainerInstanceDTO : ComponentInstanceDTO
    {
        public List<EffectInstanceDTO> ActiveEffects { get; set; } = new List<EffectInstanceDTO>();
    }

    public class EffectInstanceDTO
    {
        public string DefinitionID { get; set; } = string.Empty;
        public float? RemainingTime { get; set; }
        public float IntervalAccumulator { get; set; }
    }

    public class EquipmentInstanceDTO : ComponentInstanceDTO
    {
        public List<EquipmentSlotDTO> Slots { get; set; } = new List<EquipmentSlotDTO>();
    }

    public class EquipmentSlotDTO
    {
        public EquipmentSlot AttributeType { get; set; }
        public ItemInstanceDTO Item { get; set; } = new ItemInstanceDTO();
    }

    public class InventoryInstanceDTO : ComponentInstanceDTO
    {
        public List<ItemInstanceDTO> Items { get; set; } = new List<ItemInstanceDTO>();
    }

    public class ItemInstanceDTO
    {
        public string ID { get; set; } = string.Empty;
        public string DefinitionID { get; set; } = string.Empty;
        public int Amount { get; set; }
        public ItemQuality Quality { get; set; }
        public int? Durability { get; set; }
    }

    public class OwnershipInstanceDTO : ComponentInstanceDTO
    {
        public string UserID { get; set; } = string.Empty;
        public string PersonalRoomID { get; set; } = string.Empty;
    }

    public class TransformInstanceDTO : ComponentInstanceDTO
    {
        public int LayerZ { get; set; }
        public Vector2DTO Position { get; set; } = new Vector2DTO();
        public EntityDirection FacingDirection { get; set; }
        public EntityAction CurrentAction { get; set; }
    }

    public class WorldItemPayloadInstanceDTO : ComponentInstanceDTO
    {
        public ItemInstanceDTO Payload { get; set; } = new ItemInstanceDTO();
    }
}