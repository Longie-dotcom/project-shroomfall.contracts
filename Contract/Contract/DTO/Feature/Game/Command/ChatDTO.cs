using System;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Game.Command
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/game/command")]
#endif
    public class ChatDTO
    {
        public string PlayerInstanceID { get; set; } = string.Empty;
        public string SenderName { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
