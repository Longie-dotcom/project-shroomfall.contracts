using Contract.DTO.Runtime.EntityDomain.Component;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Game.Response
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/game/response")]
#endif
    public class EntityAppearanceChangedDTO
    {
        public string EntityInstanceID { get; set; } = string.Empty;
        public AppearanceInstanceDTO Appearance { get; set; } = new AppearanceInstanceDTO();
    }
}