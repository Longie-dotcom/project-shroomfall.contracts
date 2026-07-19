#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Admin.Response
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/admin/response")]
#endif
    public class RoomSyncChangedDTO
    {
        public string RoomSpatialID { get; set; } = string.Empty;
        public bool IsLoaded { get; set; }
    }
}
