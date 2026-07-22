namespace ZowieCrestron.Models
{
    public static class ZowieConstants
    {
        public static class StorageIndex
        {
            public const string Usb1 = "usb1_0";
            public const string SdCard = "sdcard_0";
            public const string Nas1 = "nas1_0";
        }

        public static class RecordEnable
        {
            public const int Off = 0;
            public const int On = 1;
            public const int Pause = 2;
            public const int Continue = 3;
        }

        public static class RecordFormat
        {
            public const int Mp4 = 0;
            public const int Ts = 1;
            public const int Mov = 2;
        }

        public static class RecordMode
        {
            public const int Manual = 0;
            public const int AutoStart = 1;
        }

        public static class LimitType
        {
            public const int SizeSplit = 0;
            public const int TimeSplit = 1;
        }

        public static class SizeLimit
        {
            public const int Auto = 0;
            public const int OnePointFiveGb = 1;
            public const int ThreeGb = 2;
            public const int FourGb = 3;
        }

        public static class TimeLimit
        {
            public const int Auto = 0;
            public const int FifteenMin = 1;
            public const int ThirtyMin = 2;
            public const int FortyFiveMin = 3;
        }

        public static class StreamType
        {
            public const int Local = 0;
            public const int Live = 1;
        }
    }
}
