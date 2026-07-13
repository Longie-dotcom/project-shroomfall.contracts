#if NET9_0 
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.MetaDomain.Item
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enum/meta-domain/item")]
#endif
    public enum ItemCategory
    {
        // Equippable (Armor, Accessories)
        Equippable,

        // Material (Resources, crafting components)
        Material,

        // Consumable (Potions, food)
        Consumable,

        // Placeable (Desired world position)
        Placeable,

        // Ranged (Merged RangedWeapon and ThrowableWeapon, using desired direction/velocity)
        Ranged,

        // Melee (Using entity melee/ranged characteristics)
        Melee
    }
}
