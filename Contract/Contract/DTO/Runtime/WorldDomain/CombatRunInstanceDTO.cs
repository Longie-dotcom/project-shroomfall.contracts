using Contract.Enum.WorldDomain;
using System.Collections.Generic;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Runtime.WorldDomain
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/world-domain")]
#endif
    public class CombatRunInstanceDTO
    {
        public string Id { get; set; } = string.Empty;
        public string CombatRunDefinitionID { get; set; } = string.Empty;
        public int CurrentLevel { get; set; }
        public string CurrentRoomSpatialID { get; set; } = string.Empty;
        public string LeaderEntityInstanceID { get; set; } = string.Empty;
        public IReadOnlyCollection<string> PlayerEntityInstanceIDs { get; set; } = new List<string>();
        public CombatRunStatus Status { get; set; }
    }
}