using Contract.Enum.EntityDomain;
using System;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Game.Command
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/game/command")]
#endif
    public class UpdatePlayerOwnershipDTO
    {
        public string Name { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
    }
}
