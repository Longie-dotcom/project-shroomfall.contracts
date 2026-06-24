#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Admin
{
#if NET9_0
    [ExportTsInterface(OutputDir = "admin/responses")]
#endif
    public class RoomResidencyChangedDTO
    {
        public string RoomSpatialID { get; set; } = string.Empty;
        public string PreviousState { get; set; } = string.Empty;
        public string NewState { get; set; } = string.Empty;
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "admin/responses")]
#endif
    public class UserConnectionChangedDTO
    {
        public string UserID { get; set; } = string.Empty;
        public int ActiveConnectionCount { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "admin/responses")]
#endif
    public class UserSessionChangedDTO
    {
        public string UserID { get; set; } = string.Empty;
        public string? PlayerInstanceID { get; set; } = string.Empty;
    }
}