using System;

/*
 * 常量的标志位运算
 */

namespace Demo08
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TrackItem t1 = TrackItem.Track1 | TrackItem.Track2;
            OutputInfo(t1);
            TrackItem t2 = TrackItem.Track3 | TrackItem.Track4 | TrackItem.Track5;
            OutputInfo(t2);
            TrackItem t3 = TrackItem.AllTracks;
            OutputInfo(t3);
        }

        public static void OutputInfo(TrackItem t)
        {
            string p1 = t.ToString();
            string p2 = Convert.ToString((int)t, 2).PadLeft(5, '0');
            Console.WriteLine($"{p2,-4} -- {p1}");
        }
    }

    [Flags]
    internal enum TrackItem
    {
        Track1 = 1,
        Track2 = 2,
        Track3 = 4,
        Track4 = 8,
        Track5 = 16,
        AllTracks = Track1 | Track2 | Track3 | Track4 | Track5
    }
}