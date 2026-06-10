namespace Contract.Enum.EntityDomain
{
    public enum EntityRelationshipType
    {
        Throwable,      // Projectile "delivers" AreaEffect
        Cluster,        // Projectile "spawns" another Projectile
        TriggeredBy,    // AreaEffect "is activated by" a specific creature
        AttachedTo      // WorldObject "is held by" a Creature
    }
}