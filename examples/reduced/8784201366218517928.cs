// Generated by Fuzzlyn on 2018-06-04 01:03:37
// Seed: 8784201366218517928
// Reduced from 40.0 KB to 0.5 KB
// Debug: Outputs 199
// Release: Outputs -57
struct S0
{
    public sbyte F0;
    public ulong F1;
    public byte F2;
    public bool F3;
    public S0(sbyte f0, ulong f1, byte f2, bool f3)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
    }
}

public class Program
{
    static S0 s_1 = new S0(0, 2532175942865390133UL, 239, true);
    public static void Main()
    {
        s_1 = new S0(-58, 2627568197337474661UL, 152, false);
        var vr89 = (byte)(s_1.F0 ^ 1U);
        System.Console.WriteLine((int)vr89);
    }
}
