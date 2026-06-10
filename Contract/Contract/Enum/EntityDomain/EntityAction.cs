namespace Contract.Enum.EntityDomain
{
    public enum EntityAction : byte
    {
        // --- Movement ---
        IDLE = 0,
        RUN = 1,
        SWING = 2,
        DAMAGED = 3,
        SHOOT = 4,
        NONE = 5,
    }
}