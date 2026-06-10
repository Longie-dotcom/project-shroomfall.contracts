using Contract.DTO.Common;
using Contract.Enum.EntityDomain;
using System.Collections.Generic;
using System.Numerics;

namespace Contract.DTO.Runtime
{
    public class EquipmentRuntimeDTO
    {
        public EquipmentSlot EquipmentSlot { get; set; }
        public ItemRuntimeDTO? Item { get; set; } = new ItemRuntimeDTO();
    }

    public class EntityRuntimeDTO
    {
        public string ID { set; get; } = string.Empty;
        public string DefinitionID { set; get; } = string.Empty;
        public string RoomSpatialID { get; set; } = string.Empty;
        public int LayerZ { get; set; }
        public Vector2DTO Position { get; set; } = new Vector2DTO();
        public Vector2 MovementVector { get; set; }
        public EntityDirection FacingDirection { get; set; }
        public EntityAction CurrentAction { get; set; }
        public AppearanceRuntimeDTO Appearance { get; set; } = new AppearanceRuntimeDTO();
    }

    public class WorldObjectRuntimeDTO : EntityRuntimeDTO
    {
        public InventoryRuntimeDTO? Inventory { get; set; } = new InventoryRuntimeDTO();
    }

    public class CreatureRuntimeDTO : EntityRuntimeDTO
    {
        public CharacteristicRuntimeDTO Characteristic { get; set; } = new CharacteristicRuntimeDTO();
        public InventoryRuntimeDTO Inventory { get; set; } = new InventoryRuntimeDTO();
        public int Level { get; private set; }
        public List<EffectRuntimeDTO> ActiveEffects { get; set; } = new List<EffectRuntimeDTO>();
        public List<EquipmentRuntimeDTO> Equipment { get; set; } = new List<EquipmentRuntimeDTO>();
    }

    public class PlayerRuntimeDTO : CreatureRuntimeDTO
    {
        public string UserID { get; set; } = string.Empty;
    }

    public class AppearanceRuntimeDTO
    {
        public string SkinID { get; set; } = string.Empty;
        public HSVDTO SkinColor { get; set; } = new HSVDTO();
        public string? HairID { get; set; } = string.Empty;
        public string? EyesID { get; set; } = string.Empty;
        public string? ShirtID { get; set; } = string.Empty;
        public string? PantID { get; set; } = string.Empty;
        public HSVDTO? HairColor { get; set; } = new HSVDTO();
        public HSVDTO? PantColor { get; set; } = new HSVDTO();
    }
}