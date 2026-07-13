#if NET9_0 
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.MetaDomain.Item
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enum/meta-domain/item")]
#endif
    public enum ItemConsumptionMethod
    {
        None,               // Infinite use
        ConsumeStack,       // Arrows, Potions, Placeables
        DegradeDurability,  // Swords, Pickaxes
        RemoveEntirely      // Equipment (moved to a slot), Quest Items
    }
}