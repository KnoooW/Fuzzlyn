// Generated by Fuzzlyn on 2018-07-16 19:13:19
// Seed: 622065557632182191
// Reduced from 14.8 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public byte F0;
    public byte F1;
}

class C0
{
    public S0 F0;
}

public class Program
{
    static C0[, ] s_1 = new C0[, ]{{new C0()}};
    static sbyte s_2;
    public static void Main()
    {
        s_2 = (sbyte)(0 & s_1[0, 0].F0.F0);
        byte vr4 = s_1[0, 0].F0.F1;
    }
}
