// Generated by Fuzzlyn on 2018-06-03 22:11:57
// Seed: 11339310208243530740
// Reduced from 321.4 KB to 0.3 KB
// Debug: Outputs 195
// Release: Outputs 4294967235
public class Program
{
    static sbyte s_7 = 120;
    static ulong s_34 = 0UL;
    static sbyte s_88 = -61;
    public static void Main()
    {
        s_7 = s_88;
        s_34 = (byte)(s_7 | 2U);
        System.Console.WriteLine(s_34);
    }
}
