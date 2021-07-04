namespace Znn_CLicker
{
    class StatusManager
    {
        public static bool isActive { get; set; } = false;

        public static bool useLeftMouseButton { get; set; } = true;
        public static bool useRightMouseButton { get; set; } = true;
        public static bool useMiddleMouseButton { get; set; } = false;

        public static bool useRandomMultiplier { get; set; } = false;
        public static int maxMultiplier { get; set; } = 1;
        public static int minMultiplier { get; set; } = 1;

        public static bool useDelay { get; set; } = true;
        public static bool useRandomDelay { get; set; } = false;
        public static int maxDelay { get; set; } = 5;
        public static int minDelay { get; set; } = 5;
    }
}
