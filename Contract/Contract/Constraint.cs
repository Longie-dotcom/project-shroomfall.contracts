namespace Contract
{
    public static class Constraint
    {
        public static int MAX_ITEM_AMOUNT_PER_SLOT = 33;
        public const int CHUNK_SIZE = 16;
        public const int TICK_RATE = 60;
        public const float DELTA_TIME = 1f / TICK_RATE;
        public const string GLOBAL_DEFINITION_VERSION = "global";
        public const string DEFAULT_LOCALE = "en-US";
    }
}