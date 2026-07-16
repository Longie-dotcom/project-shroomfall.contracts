namespace Contract.Enum.MetaDomain.Effect
{
    public enum VitalChangeReason
    {
        // Health - Restorative
        Heal,

        // Health - Offensive
        Critical,
        Damage,
        LifeSteal,

        // Health - Defensive
        Block,

        // Energy - Restorative
        EnergyRestore,

        // Energy - Offensive
        EnergyConsume,
    }
}