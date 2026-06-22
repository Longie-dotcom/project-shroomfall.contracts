namespace Contract
{
    public static class Constraint
    {
        public static int MAX_ITEM_AMOUNT_PER_SLOT = 33;
        public const int CHUNK_SIZE = 16;
        public const int TICK_RATE = 60;
        public const float DELTA_TIME = 1f / TICK_RATE;
        public const string GLOBAL_DEFINITION_VERSION = "global_definition";
        public const string DEFAULT_LOCALE = "en-US";
        public const string DEFAULT_ENTITY_ITEM_DEFINITION_ID = "entity.default_item";
        public const int DEFAULT_CHARACTERISTIC_LEVEL = 1;
        public const string ADMIN_REALTIME_GROUP = "Admin";
        public const float RESIDENCY_TICK_PER_SECOND = 1f;
        public const float RESIDENCY_REPORT_PER_SECOND = 10f;
    }
}