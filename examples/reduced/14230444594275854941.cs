// Generated by Fuzzlyn on 2018-07-09 05:07:55
// Seed: 14230444594275854941
// Reduced from 5.6 KiB to 0.3 KiB
// Debug: Outputs 65534
// Release: Outputs 4294967294
class C0
{
    public short F3;
    public C0(short f3)
    {
        F3 = f3;
    }
}

public class Program
{
    public static void Main()
    {
        C0 vr2 = new C0(32766);
        long vr3 = (ushort)(sbyte)vr2.F3;
        System.Console.WriteLine(vr3);
    }
}
