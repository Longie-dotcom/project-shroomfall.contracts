#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Runtime.WorldDomain
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/world-domain")]
#endif
    public class RoomSpatialDTO
    {
        public string Id { get; set; } = string.Empty;
        public string DefinitionID { get; set; } = string.Empty;
        public string? OwnerID { get; set; }
    }
}