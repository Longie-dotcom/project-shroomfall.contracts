#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.EntityDomain
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enum/entity-domain")]
#endif
    public enum EntityType
    {
        AreaEffect,
        Portal,
        Projectile,
        WorldObject,
        Creature,
        Player,
        Item,
    }
}
