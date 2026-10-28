using Contract.DTO.Abstraction;
using Contract.Enum.EntityDomain;
using System;
using System.Collections.Generic;

#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Runtime.EntityDomain.Component
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/entity-domain/component")]
#endif
    public class QuestProgressInstanceDTO : ComponentInstanceDTO
    {
        public List<QuestProgressEntryDTO> Entries { get; set; } = new List<QuestProgressEntryDTO>();

    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/entity-domain/component")]
#endif
    public class QuestProgressEntryDTO
    {
        public string QuestInstanceId { get; set; } = string.Empty;
        public DateTime StartedAt { get; set; }
        public QuestProgressStatus Status { get; set; }
#if NET9_0
        [TsOptional]
#endif
        public IdentificationProgressDTO? IdentificationProgress { get; set; }
    }

#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/entity-domain/component")]
#endif
    public class IdentificationProgressDTO
    {
        public int CorrectDefeatCount { get; set; }
        public int RequiredDefeatCount { get; set; }
        public float Percentage => RequiredDefeatCount <= 0 ? 0f : Math.Min(100f, (float)CorrectDefeatCount / RequiredDefeatCount * 100f);
    }
}