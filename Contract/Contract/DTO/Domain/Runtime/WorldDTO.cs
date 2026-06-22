using System.Collections.Generic;

namespace Contract.DTO.Domain.Runtime
{
    public class RoomRuntimeDTO
    {
        public string ID { get; set; } = string.Empty;
        public string DefinitionID { get; set; } = string.Empty;
        public string? OwnerID { get; set; }
        public List<EntityInstanceDTO> Entities { get; set; } = new List<EntityInstanceDTO>();
    }

    public class RoomConnectionRuntimeDTO
    {
        public string ID { get; set; } = string.Empty;
        public string DefinitionID { get; set; } = string.Empty;
        public string SourceRoomSpatialID { get; set; } = string.Empty;
        public string SourceEntityInstanceID { get; set; } = string.Empty;
        public string? DestinationRoomSpatialID { get; set; }
        public string? DestinationEntityInstanceID { get; set; }
        public string? ReverseConnectionID { get; set; }
    }
}