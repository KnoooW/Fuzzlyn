// Generated by Fuzzlyn on 2018-06-03 22:22:30
// Seed: 11892113616094294130
// Reduced from 139.5 KB to 0.2 KB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static ulong[, ] s_30 = new ulong[, ]{{1UL}};
    public static void Main()
    {
        int vr126 = (ushort)((18446744073709551614UL / ((0 & s_30[0, 0]) | 1)) & s_30[0, 0]);
    }
}
