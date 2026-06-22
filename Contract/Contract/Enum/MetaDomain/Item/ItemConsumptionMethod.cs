namespace Contract.Enum.MetaDomain.Item
{
    public enum ItemConsumptionMethod
    {
        None,               // Infinite use
        ConsumeStack,       // Arrows, Potions, Placeables
        DegradeDurability,  // Swords, Pickaxes
        RemoveEntirely      // Equipment (moved to a slot), Quest Items
    }
}