#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Admin.Response
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/admin/response")]
#endif
    public class RoomStateChangedDTO
    {
        public string RoomSpatialID { get; set; } = string.Empty;
        public string PreviousState { get; set; } = string.Empty;
        public string NewState { get; set; } = string.Empty;
    }
}