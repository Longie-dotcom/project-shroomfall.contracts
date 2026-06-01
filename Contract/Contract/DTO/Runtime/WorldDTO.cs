using System.Collections.Generic;

namespace Contract.DTO.Runtime
{
    public class RoomRuntimeDTO
    {
        public string ID { get; set; } = string.Empty;
        public string DefinitionID { get; set; } = string.Empty;
        public string? OwnerID { get; set; }
        public List<EntityRuntimeDTO> Entities { get; set; } = new List<EntityRuntimeDTO>();
    }

    public class RoomConnectionRuntimeDTO
    {
        public string ID { get; set; } = string.Empty;
        public string DefinitionID { get; set; } = string.Empty;
        public string SourceRoomSpatialID { get; set; } = string.Empty;
        public string SourceEntityInstanceID { get; set; } = string.Empty;
        public string? DestinationRoomSpatialID { get; set; } = string.Empty;
        public string? DestinationEntityInstanceID { get; set; } = string.Empty;
    }
}