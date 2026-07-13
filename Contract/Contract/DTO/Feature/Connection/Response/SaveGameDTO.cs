using Contract.DTO.Runtime.EntityDomain;
using Contract.DTO.Runtime.WorldDomain;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Connection.Response
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/connection/response")]
#endif
    public class SaveGameDTO
    {
        public EntityInstanceDTO PlayerData { get; set; } = new EntityInstanceDTO();
        public RoomSpatialDTO RoomData { get; set; } = new RoomSpatialDTO();
    }
}