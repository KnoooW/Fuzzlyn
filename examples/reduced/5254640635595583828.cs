// Generated by Fuzzlyn on 2018-06-04 00:01:46
// Seed: 5254640635595583828
// Reduced from 144.9 KB to 0.4 KB
// Debug: Outputs 65535
// Release: Outputs -1
class C0
{
    public ushort F4;
    public C0()
    {
    }
}

public class Program
{
    static C0[] s_1 = new C0[]{new C0()};
    public static void Main()
    {
        var vr135 = s_1[0].F4--;
        var vr136 = (ushort)(0 ^ (sbyte)M15());
        System.Console.WriteLine((int)vr136);
    }

    static ushort M15()
    {
        return s_1[0].F4;
    }
}
