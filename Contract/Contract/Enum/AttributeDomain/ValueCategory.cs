namespace Contract.Enum.AttributeDomain
{
    public enum ValueCategory
    {
        // ─────────────────────────────
        // Flat value (direct number)
        // Example: Health = 100
        // ─────────────────────────────
        Flat,

        // ─────────────────────────────
        // Percentage-based value (0–100 or 0–1 depending design)
        // Example: CritChance = +10%
        // ─────────────────────────────
        Percentage,

        // ─────────────────────────────
        // Multiplicative value
        // Example: MoveSpeed x1.2, AttackSpeed x1.5
        // ─────────────────────────────
        Multiplier,

        // ─────────────────────────────
        // Regeneration over time
        // Example: HealthRegen = +5/sec
        // ─────────────────────────────
        Regen,

        // ─────────────────────────────
        // Boolean-like or threshold-based stat
        // Example: IsImmune, CanFly (rare in your system)
        // ─────────────────────────────
        Flag
    }
}