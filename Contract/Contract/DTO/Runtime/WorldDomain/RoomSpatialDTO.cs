using Contract.DTO.Runtime.EntityDomain;
using System.Collections.Generic;

namespace Contract.DTO.Runtime.WorldDomain
{
    public class RoomSpatialDTO
    {
        public string ID { get; set; } = string.Empty;
        public string DefinitionID { get; set; } = string.Empty;
        public string? OwnerID { get; set; }
        public List<EntityInstanceDTO> Entities { get; set; } = new List<EntityInstanceDTO>();
    }
}