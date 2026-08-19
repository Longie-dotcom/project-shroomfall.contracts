using Contract.Common;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Game.Command
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/game/command")]
#endif
    public class UpdatePlayerAppearanceDTO
    {
        public string SkinID { get; set; } = string.Empty;
        public HSV SkinColor { get; set; } = new HSV();
    }
}