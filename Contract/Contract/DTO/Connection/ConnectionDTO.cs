using Contract.DTO.Domain.Runtime;
using System.Collections.Generic;

namespace Contract.DTO.Connection
{
    public class ExistedSessionEntryDTO
    {
        public string PlayerInstanceID { get; set; } = string.Empty;
        public AppearanceInstanceDTO PlayerAppearance { get; set; } = new AppearanceInstanceDTO();
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
        public EntityInstanceDTO PlayerData { get; set; } = new EntityInstanceDTO();
        public RoomRuntimeDTO RoomData { get; set; } = new RoomRuntimeDTO();
    }
}
