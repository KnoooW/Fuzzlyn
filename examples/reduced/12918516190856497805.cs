// Generated by Fuzzlyn on 2018-06-03 22:35:25
// Seed: 12918516190856497805
// Reduced from 95.2 KB to 0.3 KB
// Debug: Outputs 129
// Release: Outputs 65409
class C0
{
    public ushort F3;
    public C0()
    {
    }
}

public class Program
{
    static C0 s_8 = new C0();
    static sbyte s_20 = -127;
    public static void Main()
    {
        s_8.F3 = (byte)(s_20 ^ 0U);
        System.Console.WriteLine(s_8.F3);
    }
}
