namespace Contract
{
    public static class NetworkMethod
    {
        #region Event
        public const string OnEntityActed = "OnEntityActed";
        public const string OnEntityVitalChanged = "OnEntityVitalChanged";
        public const string OnPlayerCharacteristicSync = "OnPlayerCharacteristicSync";
        public const string OnInventoryItemChanged = "OnInventoryItemChanged";
        public const string OnInventoryCleared = "OnInventoryCleared";
        public const string OnEntitySpawned = "OnEntitySpawned";
        public const string OnEntityDespawned = "OnEntityDespawned";
        public const string OnPlayerAppearanceChanged = "OnPlayerAppearanceChanged";
        public const string OnRoomSnapshotUpdated = "OnRoomSnapshotUpdated";

        public const string OnDefinitionUpdated = "OnDefinitionUpdated";

        public const string OnTelemetrySended = "OnTelemetrySended";
        public const string OnRoomStateChanged = "OnRoomStateChanged";
        public const string OnRoomSyncChanged = "OnRoomSyncChanged";
        public const string OnUserConnectionChanged = "OnUserConnectionChanged";
        public const string OnUserSessionChanged = "OnUserSessionChanged";
        #endregion

        #region Request
        public const string Move = "Move";
        #endregion
    }
}