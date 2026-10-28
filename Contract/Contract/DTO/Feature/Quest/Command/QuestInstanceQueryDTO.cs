using Contract.Enum.MetaDomain.Quest;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Quest.Command
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/design/command")]
#endif
    public class QuestInstanceQueryDTO
    {
#if NET9_0
        [TsOptional]
#endif
        public string? SearchTerm { get; set; }
#if NET9_0
        [TsOptional]
#endif
        public QuestType? Type { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}