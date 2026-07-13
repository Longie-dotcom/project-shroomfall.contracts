using Contract.DTO.Definition.LocalizationDomain;
using Contract.Enum.WorldDomain;
using System;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Definition.WorldDomain
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/world-domain")]
#endif
    public class RoomDefinitionDTO
    {
        public string ID { get; set; } = string.Empty;
        public RoomType Type { get; set; }
        public RoomPresentationDefinitionDTO Presentation { get; set; } = new RoomPresentationDefinitionDTO();
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/world-domain")]
#endif
    public class RoomPresentationDefinitionDTO
    {
        public LocalizedTextDTO LocalizedText { get; set; } = new LocalizedTextDTO();
        public string? IconID { get; set; } = string.Empty;
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/world-domain")]
#endif
    public class EntitySpawnRuleDTO
    {
        public Guid ID { get; set; }
        public SpawnRuleType Type { get; set; }
        public int MinX { get; set; }
        public int MinY { get; set; }
        public int MaxX { get; set; }
        public int MaxY { get; set; }
        public int MinCount { get; set; }
        public int MaxCount { get; set; }
        public string RoomDefinitionID { get; set; } = string.Empty;
        public string EntityDefinitionID { get; set; } = string.Empty;
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/definition/world-domain")]
#endif
    public class CellDTO
    {
        public string RoomDefinitionID { get; set; } = string.Empty;
        public CellType Type { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }
}