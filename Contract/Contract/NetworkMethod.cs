namespace Contract
{
    public static class NetworkMethod
    {
        #region Event
        public const string OnEntityActed = "OnEntityActed";
        public const string OnEntityVitalChanged = "OnEntityVitalChanged";
        public const string OnPlayerCharacteristicSync = "OnPlayerCharacteristicSync";
        public const string OnEntitySpawned = "OnEntitySpawned";
        public const string OnEntityDespawned = "OnEntityDespawned";
        public const string OnPlayerAppearanceChanged = "OnPlayerAppearanceChanged";
        
        public const string OnDefinitionUpdated = "OnDefinitionUpdated";
        #endregion

        #region Request
        public const string Move = "Move";
        #endregion
    }
}