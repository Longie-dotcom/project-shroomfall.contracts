#if NET9_0 
using TypeGen.Core.TypeAnnotations;
#endif

namespace Contract.Enum.MetaDomain.Item
{
#if NET9_0
    [ExportTsEnum(OutputDir = "enums/meta/item")]
#endif
    public enum SpawnTargetType
    {
        WorldPosition, // Spawns directly at the targeted coordinates (e.g., place a building/chest)
        Directional,   // Spawns with an initial velocity/trajectory vector (e.g., shoot a projectile)
        AoE            // Spawns centered on a location but applies an area radius check
    }
}