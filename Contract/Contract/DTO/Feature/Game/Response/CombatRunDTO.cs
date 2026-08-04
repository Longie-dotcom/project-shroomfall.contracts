using Contract.DTO.Feature.Connection.Response;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Game.Response
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/game/response")]
#endif
    public class CombatRunDTO
    {
        public string CombatRunInstanceID { get; set; } = string.Empty;
        public SaveGameDTO SaveGame { get; set; } = default!;
    }
}
