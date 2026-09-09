using Contract.DTO.Definition.EntityDomain.Component;
using Contract.DTO.Definition.LocalizationDomain;
using Contract.DTO.Definition.MetaDomain;
using Contract.DTO.Definition.WorldDomain;
using System.Collections.Generic;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.DTO.Feature.Design.Response
{
#if NET9_0
    [ExportTsInterface(OutputDir = "dto/feature/design/response")]
#endif
    public class DefinitionSnapshotDTO
    {
        public long Version { get; set; }

        public List<EffectDefinitionDTO> Effects { get; set; } = new List<EffectDefinitionDTO>();
        public List<ItemDefinitionDTO> Items { get; set; } = new List<ItemDefinitionDTO>();

        public List<EntityDefinitionDTO> Entities { get; set; } = new List<EntityDefinitionDTO>();

        public List<RoomDefinitionDTO> Rooms { get; set; } = new List<RoomDefinitionDTO>();

        public List<LocaleDTO> Locales { get; set; } = new List<LocaleDTO>();
    }
}