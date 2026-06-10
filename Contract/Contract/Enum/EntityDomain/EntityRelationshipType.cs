namespace Contract.Enum.EntityDomain
{
    public enum EntityRelationshipType
    {
        Throwable,      // Projectile "delivers" AreaEffect
        ProjectileTriggeredBy,    // Projectile "is activated by" a specific creature
        AreaEffectTriggeredBy,    // Area Effect "is activated by" a specific creature
        AttachedTo      // WorldObject "is held by" a Creature
    }
}