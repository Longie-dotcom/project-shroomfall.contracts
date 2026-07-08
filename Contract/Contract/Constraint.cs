using System.Collections.Generic;

namespace Contract
{
    public static class Constraint
    {
        // Default versioning
        public const string GLOBAL_DEFINITION_VERSION = "global_definition";

        // Design rules
        public static int MAX_ITEM_AMOUNT_PER_SLOT = 33;
        public const string DEFAULT_ENTITY_ITEM_DEFINITION_ID = "entity.default_item";
        public const int DEFAULT_CHARACTERISTIC_LEVEL = 1;
        public const int CHUNK_SIZE = 16;

        // Ticking constraints
        public const float RESIDENCY_TICK_PER_SECOND = 1f;
        public const float RESIDENCY_REPORT_PER_SECOND = 10f;
        public const int TICK_RATE = 60;
        public const float DELTA_TIME = 1f / TICK_RATE;

        // Admin constraints
        public const string ADMIN_REALTIME_GROUP = "Admin";

        // Static world
        public static readonly IReadOnlyCollection<(string DefinitionKey, string SpatialId)> STATIC_HUB_ROOM_MAPS =
            new HashSet<(string DefinitionKey, string SpatialId)>
            {
                ("hub.village", "hub.village.main-square"),
                ("hub.village", "hub.village.market-district"),
                ("hub.village", "hub.village.tavern-zone"),
                ("hub.castle",  "hub.castle.courtyard")
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