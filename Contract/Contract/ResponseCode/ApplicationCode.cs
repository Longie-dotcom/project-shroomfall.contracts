namespace ResponseCode
{
    public class ApplicationCode
    {
        private static string Code(string className, string problem) => CodeFormatter.Create("application", className, problem);

        #region Features
        public static class ConnectionHandlerCode
        {
            private static string Format(string problem) => Code("connection-handler", problem);

            // Unload Session Handler
            public static string UnloadSessionPlayerInstanceNotFound = Format("unload-session-player-instance-not-found");
            public static string UnloadSessionTransformMissing = Format("unload-session-transform-missing");
            
            // Load Session Handler
            public static string LoadSessionUnauthorizedPlayer = Format("load-session-unauthorized-player");
        }

        public static class DesignHandlerCode
        {
            private static string Format(string problem) => Code("design-handler", problem);

            // Fetch Entity Definition Detail Handler
            public static string EntityDefinitionNotFound = Format("entity-definition-not-found");

            // Update Localization Entry Handler
            public static string LocalizationEntryNotFound = Format("localization-entry-not-found");

            // Import Combat Run Definition Handler
            public static string CombatRunFilePayloadEmpty = Format("combat-run-file-payload-empty");
            public static string CombatRunFileInvalidJson = Format("combat-run-file-invalid-json");
            public static string CombatRunFileSchemaParseFailed = Format("combat-run-file-schema-parse-failed");

            // Import Effect Definitions Handler
            public static string EffectFilePayloadEmpty = Format("effect-file-payload-empty");
            public static string EffectFileInvalidJson = Format("effect-file-invalid-json");
            public static string EffectFileSchemaParseFailed = Format("effect-file-schema-parse-failed");

            // Import Entity Definitions Handler
            public static string EntityFilePayloadEmpty = Format("entity-file-payload-empty");
            public static string EntityFileInvalidJson = Format("entity-file-invalid-json");
            public static string EntityFileSchemaParseFailed = Format("entity-file-schema-parse-failed");

            // Import Item Definitions Handler
            public static string ItemFilePayloadEmpty = Format("item-file-payload-empty");
            public static string ItemFileInvalidJson = Format("item-file-invalid-json");
            public static string ItemFileSchemaParseFailed = Format("item-file-schema-parse-failed");

            // Import Room Definition Handler
            public static string RoomFilePayloadEmpty = Format("room-file-payload-empty");
            public static string RoomFileInvalidJson = Format("room-file-invalid-json");
            public static string RoomFileSchemaParseFailed = Format("room-file-schema-parse-failed");
        }

        public static class GameHandlerCode
        {
            private static string Format(string problem) => Code("game-handler", problem);

            // Back Home Handler
            public static string BackHomeSessionNotFound = Format("back-home-session-not-found");
            public static string BackHomePlayerInstanceNotFound = Format("back-home-player-instance-not-found");
            public static string BackHomeOwnershipInstanceNotFound = Format("back-home-ownership-instance-not-found");

            // Create Combat Run Handler
            public static string CreateCombatRunSessionNotFound = Format("create-combat-run-session-not-found");
            public static string CreateCombatRunPlayerInstanceNotFound = Format("create-combat-run-player-instance-not-found");
            public static string CreateCombatRunPlayerAlreadyInCombatRun = Format("create-combat-run-player-already-in-combat-run");
            public static string CreateCombatRunDefinitionNotFound = Format("create-combat-run-definition-not-found");

            // Enter Hub Handler
            public static string EnterHubInvalidHubRoom = Format("enter-hub-invalid-hub-room");
            public static string EnterHubSessionNotFound = Format("enter-hub-session-not-found");
            public static string EnterHubPlayerInstanceNotFound = Format("enter-hub-player-instance-not-found");

            // Move Handler
            public static string MoveSessionNotFound = Format("move-session-not-found");
            public static string MovePlayerInstanceNotFound = Format("move-player-instance-not-found");
            public static string MoveTransformMissing = Format("move-transform-missing");

            // Update Appearance Handler
            public static string UpdateAppearanceSessionNotFound = Format("update-appearance-session-not-found");
            public static string UpdateAppearancePlayerInstanceNotFound = Format("update-appearance-player-instance-not-found");
            public static string UpdateAppearanceComponentMissing = Format("update-appearance-component-missing");
            public static string UpdateAppearanceTransformMissing = Format("update-appearance-transform-missing");

            // Use Item Handler
            public static string UseItemSessionNotFound = Format("use-item-session-not-found");
            public static string UseItemPlayerInstanceNotFound = Format("use-item-player-instance-not-found");
            public static string UseItemActionComponentMissing = Format("use-item-action-component-missing");
        }

        public static class IdentityHandlerCode
        {
            private static string Format(string problem) => Code("identity-handler", problem);

            // Login Handler
            public static string LoginEmailRequired = Format("login-email-required");
            public static string LoginPasswordRequired = Format("login-password-required");
            public static string LoginInvalidCredentials = Format("login-invalid-credentials");

            // Refresh Token Handler
            public static string RefreshTokenUserNotFound = Format("refresh-token-user-not-found");

            // Register Handler
            public static string RegisterEmailRequired = Format("register-email-required");
            public static string RegisterEmailAlreadyExists = Format("register-email-already-exists");

            // Steam Auth Handler
            public static string SteamAuthInvalidSteamTicket = Format("steam-auth-invalid-steam-ticket");
            public static string SteamAuthValidationFailed = Format("steam-auth-validation-failed");

            // Update Profile Handler
            public static string UpdateProfileUserNotFound = Format("update-profile-user-not-found");
        }
        #endregion

        #region Services
        // Design Service
        public static class ComponentDiscoveryRegistryCode
        {
            private static string Format(string problem) => Code("component-discovery-registry", problem);

            public static string DTOMissingAttribute = Format("dto-missing-attribute");
        }

        public static class EntityDefinitionServiceCode
        {
            private static string Format(string problem) => Code("entity-definition-service", problem);

            public static string MandatorySchemaElementsMissing = Format("mandatory-schema-elements-missing");
        }

        public static class ItemDefinitionServiceCode
        {
            private static string Format(string problem) => Code("item-definition-service", problem);

            public static string ItemCategoryConfigMissing = Format("item-category-config-missing");
            public static string ItemCategoryConfigConflict = Format("item-category-config-conflict");
        }

        public static class DefinitionComponentFactoryCode
        {
            private static string Format(string problem) => Code("definition-component-factory", problem);

            public static string ComponentDTOMappingFailed = Format("component-dto-mapping-failed");
        }

        // Entity Service
        public static class InventoryServiceCode
        {
            private static string Format(string problem) => Code("inventory-service", problem);

            public static string DropSourceInventoryMissing = Format("drop-source-inventory-missing");
            public static string RemoveTargetInventoryMissing = Format("remove-target-inventory-missing");
        }

        // Meta Service
        public static class ItemServiceCode
        {
            private static string Format(string problem) => Code("item-service", problem);

            public static string PlaceableMissingTransform = Format("placeable-missing-transform");
            public static string RangedMissingTransform = Format("ranged-missing-transform");
            public static string MeleeMissingTransform = Format("melee-missing-transform");
        }

        // World Service
        public static class EntitySpawnServiceCode
        {
            private static string Format(string problem) => Code("entity-spawn-service", problem);

            public static string SpawnEntityCreationFailed = Format("spawn-entity-creation-failed");
            public static string ActivateTransformMissing = Format("activate-transform-missing");
            public static string TransitionTransformMissing = Format("transition-transform-missing");
        }

        public static class InitializationServiceCode
        {
            private static string Format(string problem) => Code("initialization-service", problem);

            public static string RoomDefinitionNotFound = Format("room-definition-not-found");
            public static string TransformComponentMissing = Format("transform-component-missing");
            public static string CollisionComponentMissing = Format("collision-component-missing");
            public static string NoSpawnCellFound = Format("no-spawn-cell-found");
        }

        public static class DefinitionRuntimeFactoryCode
        {
            private static string Format(string problem) => Code("definition-runtime-factory", problem);

            public static string AIDefinitionNotFound = Format("ai-definition-not-found");
            public static string AppearanceDefinitionNotFound = Format("appearance-definition-not-found");
            public static string CollisionDefinitionNotFound = Format("collision-definition-not-found");
            public static string CharacteristicDefinitionNotFound = Format("characteristic-definition-not-found");
            public static string InventoryDefinitionNotFound = Format("inventory-definition-not-found");
            public static string LifetimeDefinitionNotFound = Format("lifetime-definition-not-found");
            public static string ProjectileDefinitionNotFound = Format("projectile-definition-not-found");
            public static string TriggeredEffectDefinitionNotFound = Format("triggered-effect-definition-not-found");
        }

        public static class SnapshotRuntimeFactoryCode
        {
            private static string Format(string problem) => Code("snapshot-runtime-factory", problem);

            public static string SnapshotTypeNotSupported = Format("snapshot-type-not-supported");
            public static string AIDefinitionNotFound = Format("ai-definition-not-found");
            public static string CollisionDefinitionNotFound = Format("collision-definition-not-found");
            public static string CharacteristicDefinitionNotFound = Format("characteristic-definition-not-found");
            public static string InventoryDefinitionNotFound = Format("inventory-definition-not-found");
            public static string LifetimeDefinitionNotFound = Format("lifetime-definition-not-found");
            public static string ProjectileDefinitionNotFound = Format("projectile-definition-not-found");
            public static string TriggeredEffectDefinitionNotFound = Format("triggered-effect-definition-not-found");
            public static string ItemDefinitionNotFound = Format("item-definition-not-found");
        }

        public static class EntityInstanceFactoryCode
        {
            private static string Format(string problem) => Code("entity-instance-factory", problem);

            public static string InvalidItemContextType = Format("invalid-item-context-type");
            public static string InvalidPlayerContextType = Format("invalid-player-context-type");
            public static string InvalidProjectileContextType = Format("invalid-projectile-context-type");
            public static string EntityTypeNotSupported = Format("entity-type-not-supported");
            public static string EntityDefinitionNotFound = Format("entity-definition-not-found");
        }

        public static class RoomSpatialFactoryCode
        {
            private static string Format(string problem) => Code("room-spatial-factory", problem);

            public static string RehydrateDefinitionNotFound = Format("rehydrate-definition-not-found");
            public static string RehydrateRoomWithoutCells = Format("rehydrate-room-without-cells");
            public static string CreateDefinitionNotFound = Format("create-definition-not-found");
            public static string CreateRoomWithoutCells = Format("create-room-without-cells");
        }

        public static class PartyServiceCode
        {
            private static string Format(string problem) => Code("party-service", problem);

            public static string RunAlreadyRegistered = Format("run-already-registered");
            public static string PlayerAlreadyInRun = Format("player-already-in-run");
            public static string PlayerAlreadyRegistered = Format("player-already-registered");
        }

        public static class ResidencyServiceCode
        {
            private static string Format(string problem) => Code("residency-service", problem);

            public static string PlayerNotFoundInSystem = Format("player-not-found-in-system");
            public static string RoomSnapshotPersistenceFailed = Format("room-snapshot-persistence-failed");
            public static string RoomSpatialNotFoundInRuntime = Format("room-spatial-not-found-in-runtime");
            public static string RoomInstanceNotFoundInPersistence = Format("room-instance-not-found-in-persistence");
            public static string StateHeartbeatReport = Format("state-heartbeat-report");
        }

        public static class RoomMigrationServiceCode
        {
            private static string Format(string problem) => Code("room-migration-service", problem);

            public static string TransformMissing = Format("transform-missing");
            public static string RoomDefinitionNotFound = Format("room-definition-not-found");
            public static string PlayerSpawnRuleMissing = Format("player-spawn-rule-missing");
            public static string SpawnCellNotFound = Format("spawn-cell-not-found");
        }

        public static class WorldContextCode
        {
            private static string Format(string problem) => Code("world-context", problem);

            public static string RoomLoaded = Format("room-loaded");
            public static string UnloadTargetMissing = Format("unload-target-missing");
            public static string RoomUnloading = Format("room-unloading");
            public static string EntityRoomChanged = Format("entity-room-changed");
        }
        #endregion
    }
}