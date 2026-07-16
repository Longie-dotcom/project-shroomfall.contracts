using System.Collections.Generic;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Definition.WorldDomain
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/world-domain")]
#endif
    public class CombatRunDefinitionDTO
    {
        public string Id { get; set; } = string.Empty;
        public List<FloorDTO> Floors { get; set; } = new List<FloorDTO>();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/world-domain")]
#endif
    public class FloorDTO
    {
        public int Level { get; set; }
        public string RoomDefinitionID { get; set; } = string.Empty;
    }
}