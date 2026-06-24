#if NET9_0 
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.MetaDomain.Item
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enums/meta/item")]
#endif
    public enum ItemType
    {
        Material,
        Consumable,
        Placeable,

        RangedWeapon,
        MeleeWeapon,
        ThrowableWeapon,
        HeavyWeapon,
        MagicWeapon,

        Equippable,
    }
}
