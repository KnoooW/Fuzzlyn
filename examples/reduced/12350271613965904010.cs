// Generated by Fuzzlyn on 2018-06-03 22:27:50
// Seed: 12350271613965904010
// Reduced from 102.7 KB to 0.4 KB
// Debug: Outputs 65437
// Release: Outputs 4294967197
class C0
{
    public ulong F1;
    public ulong F5;
    public C0(ulong f1)
    {
        F1 = f1;
    }
}

public class Program
{
    static C0[] s_23 = new C0[]{new C0(11266750174733769116UL)};
    public static void Main()
    {
        var vr63 = s_23[0];
        vr63.F5 = (ushort)(sbyte)(vr63.F1 ^ 1UL);
        System.Console.WriteLine(s_23[0].F5);
    }
}
