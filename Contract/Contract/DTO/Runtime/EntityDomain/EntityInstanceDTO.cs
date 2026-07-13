using Contract.DTO.Abstraction;
using System.Collections.Generic;

namespace Contract.DTO.Runtime.EntityDomain
{
    public class EntityInstanceDTO
    {
        public string ID { get; set; } = string.Empty;
        public string DefinitionID { get; set; } = string.Empty;
        public List<ComponentInstanceDTO> Components { get; set; } = new List<ComponentInstanceDTO>();
    }
}