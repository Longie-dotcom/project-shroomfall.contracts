#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.MetaDomain.Item
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enum/meta-domain/item")]
#endif
    public enum ItemUsageAction
    {
        None,
        Use,      // Consumables, Placeables, Ranged/Melee triggers, Equippable
        Unequip   // Removing item from an equipment slot
    }
}