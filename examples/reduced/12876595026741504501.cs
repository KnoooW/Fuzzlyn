// Generated by Fuzzlyn on 2018-06-03 22:34:24
// Seed: 12876595026741504501
// Reduced from 77.3 KB to 0.2 KB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static ulong s_16 = 2UL;
    static uint[, ] s_27 = new uint[, ]{{2315356874U}};
    public static void Main()
    {
        bool vr48 = 13611585788014464075UL >= (((0 & s_27[0, 0]) % s_16) * s_27[0, 0]);
    }
}
