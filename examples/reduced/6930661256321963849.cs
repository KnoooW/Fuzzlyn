// Generated by Fuzzlyn v1.1 on 2018-08-24 21:02:48
// Seed: 6930661256321963849
// Reduced from 58.1 KiB to 0.4 KiB
// Debug: Outputs 88
// Release: Outputs -18600
struct S2
{
    public byte F0;
    public short F1;
    public uint F2;
    public int F3;
    public long F4;
    public S2(short f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    public static void Main()
    {
        S2 vr0 = new S2(-18600);
        long vr1 = (sbyte)vr0.F1;
        System.Console.WriteLine(vr1);
    }
}
