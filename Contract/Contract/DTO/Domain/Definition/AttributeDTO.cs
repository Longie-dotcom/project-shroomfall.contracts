using Contract.Enum.MetaDomain.Effect;

namespace Contract.DTO.Domain.Definition
{
    public class AttributeDefinitionDTO
    {
        public AttributeType Type { get; set; }
        public LocalizedTextDTO LocalizedText { get; set; } = new LocalizedTextDTO();
        public DomainType DomainType { get; set; }
    }
}