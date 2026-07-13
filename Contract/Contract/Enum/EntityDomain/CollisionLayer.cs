using System;
#if NET9_0
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.EntityDomain
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enum/entity-domain")]
#endif
    [Flags]
    public enum CollisionLayer
    {
        None = 0,
        Wall = 1 << 0,  // 1  - Solid environment, tiles, trees
        Player = 1 << 1,  // 2  - The player entities
        Enemy = 1 << 2,  // 4  - Monsters, bosses, bad guys
        PlayerProjectile = 1 << 3,  // 8  - Fireballs, arrows shot by players
        EnemyProjectile = 1 << 4,  // 16 - Spells, bullets shot by enemies
        TriggerZone = 1 << 5,  // 32 - Spike traps, area-of-effect clouds, town doors
        Collectible = 1 << 6   // 64 - Gold coins, potions, mushroom drops
    }
}