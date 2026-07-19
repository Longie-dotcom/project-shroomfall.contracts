#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

using Contract.DTO.Runtime.WorldDomain;

namespace Contract.DTO.Feature.Admin.Response
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/admin/response")]
#endif
    public class RoomSyncChangedDTO
    {
        public RoomSpatialDTO RoomSpatial { get; set; } = new RoomSpatialDTO();
        public bool IsLoaded { get; set; }
    }
}
