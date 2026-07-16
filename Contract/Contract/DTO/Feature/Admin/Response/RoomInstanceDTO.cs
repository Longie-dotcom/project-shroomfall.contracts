#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif
using Contract.DTO.Runtime.EntityDomain;
using Contract.DTO.Runtime.WorldDomain;
using System.Collections.Generic;

namespace Contract.DTO.Feature.Admin.Response
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/admin/response")]
#endif
    public class RoomInstanceDTO
    {
        public RoomSpatialDTO Room { get; set; } = new RoomSpatialDTO();
        public List<EntityInstanceDTO> Entities { get; set; } = new List<EntityInstanceDTO>();
    }
}
