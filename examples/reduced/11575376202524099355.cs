// Generated by Fuzzlyn on 2018-07-19 23:22:47
// Seed: 11575376202524099355
// Reduced from 89.8 KiB to 0.2 KiB
// Debug: Outputs 65529
// Release: Outputs -7
public class Program
{
    static sbyte s_1 = -7;
    public static void Main()
    {
        short[, ] vr4 = new short[, ]{{0}};
        char vr5 = (char)(s_1 | vr4[0, 0]);
        System.Console.WriteLine((int)vr5);
    }
}
