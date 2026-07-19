using Contract.DTO.Runtime.EntityDomain;
using System.Collections.Generic;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Runtime.WorldDomain
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/world-domain")]
#endif
    public class RoomInstanceDTO
    {
        public RoomSpatialDTO Room { get; set; } = new RoomSpatialDTO();
        public List<EntityInstanceDTO> Entities { get; set; } = new List<EntityInstanceDTO>();
    }
}
