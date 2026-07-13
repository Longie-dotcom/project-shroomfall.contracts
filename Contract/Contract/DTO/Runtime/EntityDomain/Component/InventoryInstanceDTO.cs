using Contract.DTO.Abstraction;
using Contract.DTO.Runtime.MetaDomain;
using System.Collections.Generic;

namespace Contract.DTO.Runtime.EntityDomain.Component
{
    public class InventoryInstanceDTO : ComponentInstanceDTO
    {
        public List<ItemInstanceDTO> Items { get; set; } = new List<ItemInstanceDTO>();
    }
}