using Contract.DTO.Abstraction;
using Contract.DTO.Runtime.MetaDomain;
using System.Collections.Generic;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Runtime.EntityDomain.Component
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/runtime/entity-domain/component")]
#endif
    public class InventoryInstanceDTO : ComponentInstanceDTO
    {
        public List<ItemInstanceDTO> Items { get; set; } = new List<ItemInstanceDTO>();
    }
}