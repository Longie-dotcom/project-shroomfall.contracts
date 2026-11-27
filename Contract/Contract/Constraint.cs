using System.Collections.Generic;

namespace Contract
{
    public static class Constraint
    {
        // Combat instance ID generation
        public const int ACCESS_TOKEN_EXPIRY_MINUTES = 15;
        public const int REFRESH_TOKEN_EXPIRY_DAYS = 7;

        // Default versioning
        public const string GLOBAL_DEFINITION_VERSION = "global_definition";

        // Design rules
        public const float POPULATION_TICK_PER_SECOND = 3f; 
        public const string DEFAULT_ENTITY_ITEM_DEFINITION_ID = "default_item";
        public const int DEFAULT_CHARACTERISTIC_LEVEL = 1;
        public const int CHUNK_SIZE = 16;
        public const int ITEM_DEGRADED_VALUE = 1;
        public const int ITEM_DEDUCTED_VALUE = 1;
        public const int ITEM_COOLDOWN_VALUE = 5;
        public const int ITEM_ENERGY_USAGE_CONSUME = 5;
        public const float CRITICAL_DAMAGE_VALUE = 1.95f; // Add 95% current damage
        public const float LOCK_ACTION_DURATION = 0.2f;
        public const int DEFAULT_ECONOMY = 0;
        public const float SELL_PRICE_REDUCTION = 0.05f; // player gets 5% less than the buy price when selling
        public const int MAX_ACTIVE_QUESTS = 3;

        public const float DROP_ITEM_OFFSET = 1.5f; // distance from the player a dropped item lands, so it isn't re-picked instantly

        // Player death rules
        public const float PLAYER_DEATH_MONEY_LOSS_RATE = 0.4f; // player loses 40% of current money on death
        public const int PLAYER_DEATH_DROP_ITEM_COUNT = 5; // random unequipped stacks dropped on death
        public const float PLAYER_RESPAWN_HEALTH_RATE = 0.6f; // health restored to 60% of max on respawn

        // Ticking constraints
        public const float RESIDENCY_TICK_PER_SECOND = 1f;
        public const float RESIDENCY_REPORT_PER_SECOND = 10f;
        public const int TICK_RATE = 60;
        public const float DELTA_TIME = 1f / TICK_RATE;

        // Chat constraints
        public const int CHAT_HISTORY_LIMIT = 50; // oldest message is dropped past this
        public const int CHAT_MESSAGE_MAX_LENGTH = 200;
        public const float CHAT_COOLDOWN_SECONDS = 1f; // per player, against spam

        // Admin constraints
        public const string ADMIN_REALTIME_GROUP = "Admin";

        // Static world
        public static readonly IReadOnlyCollection<(string DefinitionKey, string SpatialId)> STATIC_HUB_ROOM_MAPS =
            new HashSet<(string DefinitionKey, string SpatialId)>
            {
                ("village", "village"),
                ("forest", "forest"),
            };

        // Supported locales
        public const string DEFAULT_LOCALE = "en-US";
        public const string VIETNAMESE_LOCALE = "vi-VN";
        public static readonly IReadOnlyCollection<(string code, string name)> SUPPORTED_LOCALES = new List<(string, string)>
        {
            (DEFAULT_LOCALE, "English (United States)"),
            (VIETNAMESE_LOCALE, "Tiếng Việt (Việt Nam)"),
        };
    }
}