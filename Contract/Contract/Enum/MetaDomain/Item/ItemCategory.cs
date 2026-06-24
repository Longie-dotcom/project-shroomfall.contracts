#if NET9_0 
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.MetaDomain.Item
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enums/meta/item")]
#endif
    public enum ItemCategory
    {
        // Equippable 
        Equippable,

        // Material
        Material,

        // Consumable
        Consumable,

        // Placeable
        Placeable,

        // RangedWeapon
        RangedWeapon,

        // MeleeWeapon
        MeleeWeapon,

        // ThrowableWeapon
        ThrowableWeapon,
    }
}
