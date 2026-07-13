using Contract.Enum.WorldDomain;
using System.Collections.Generic;

namespace Contract.DTO.Runtime.WorldDomain
{
    public class CombatRunInstanceDTO
    {
        public string ID { get; set; } = string.Empty;
        public string CombatRunDefinitionID { get; set; } = string.Empty;
        public int CurrentLevel { get; set; }
        public string CurrentRoomSpatialID { get; set; } = string.Empty;
        public string LeaderEntityInstanceID { get; set; } = string.Empty;
        public IReadOnlyCollection<string> PlayerEntityInstanceIDs { get; set; } = new List<string>();
        public CombatRunStatus Status { get; set; }
    }
}