// Generated by Fuzzlyn on 2018-07-24 17:04:38
// Seed: 2746055471016177177
// Reduced from 6.9 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public sbyte F0;
    public char F2;
}

public class Program
{
    static C0[, ] s_1 = new C0[, ]{{new C0()}};
    public static void Main()
    {
        byte vr1 = (byte)((0 & s_1[0, 0].F0) / (s_1[0, 0].F2 | 1));
    }
}
