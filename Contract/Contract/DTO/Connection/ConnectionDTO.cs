using Contract.DTO.Runtime;
using System.Collections.Generic;

namespace Contract.DTO.Connection
{
    public class ExistedSessionEntryDTO
    {
        public string PlayerInstanceID { get; set; } = string.Empty;
        public PlayerAppearanceRuntimeDTO PlayerAppearance { get; set; } = new PlayerAppearanceRuntimeDTO();
    }

    public class RoomSnapshotDTO
    {
        public RoomRuntimeDTO RoomData { get; set; } = new RoomRuntimeDTO();
    }

    public class ExistedSessionDTO
    {
        public List<ExistedSessionEntryDTO> Sessions { get; set; } = new List<ExistedSessionEntryDTO>();
    }

    public class SaveGameDTO
    {
        public PlayerRuntimeDTO PlayerData { get; set; } = new PlayerRuntimeDTO();
        public RoomRuntimeDTO RoomData { get; set; } = new RoomRuntimeDTO();
    }
}
