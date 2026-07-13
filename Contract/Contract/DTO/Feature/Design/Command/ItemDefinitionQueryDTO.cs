using Contract.Enum.MetaDomain.Item;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Design.Command
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/design/command")]
#endif
    public class ItemDefinitionQueryDTO
    {
        public string? SearchTerm { get; set; }
        public ItemType? Type { get; set; }
        public ItemCategory? Category { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}