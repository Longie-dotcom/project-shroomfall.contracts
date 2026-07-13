#if NET9_0 
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.MetaDomain.Item
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enum/meta-domain/item")]
#endif
    public enum EquipmentSlot
    {
        Head,
        Chest,
        Pant,
        Shoe
    }
}