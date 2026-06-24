using Contract.Enum.MetaDomain.Effect;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Domain.Definition
{
#if NET9_0
    [ExportTsInterface(OutputDir = "domain/definition/attribute")]
#endif
    public class AttributeDefinitionDTO
    {
        public AttributeType Type { get; set; }
        public LocalizedTextDTO LocalizedText { get; set; } = new LocalizedTextDTO();
        public DomainType DomainType { get; set; }
    }
}