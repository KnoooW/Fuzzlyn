// Generated by Fuzzlyn on 2018-06-03 22:44:58
// Seed: 1388937088641249784
// Reduced from 43.2 KB to 1.2 KB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public C0()
    {
    }
}

class C1
{
    public C1()
    {
    }
}

struct S0
{
    public uint F0;
    public short F1;
    public C0 F2;
    public bool F3;
    public uint F4;
    public S0(uint f0, short f1, C0 f2, bool f3, uint f4)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
    }
}

class C2
{
    public sbyte F0;
    public C2()
    {
    }
}

class C3
{
    public C3()
    {
    }
}

struct S2
{
    public long F0;
    public C1 F1;
    public long F2;
    public C3 F3;
    public C2 F4;
    public sbyte F5;
    public S0 F6;
    public S2(long f0, C1 f1, long f2, C3 f3, C2 f4, sbyte f5, S0 f6)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
        F5 = f5;
        F6 = f6;
    }
}

struct S4
{
    public S2 F0;
    public S4(S2 f0)
    {
        F0 = f0;
    }
}

public class Program
{
    public static void Main()
    {
        S4 vr11 = new S4(new S2(2719843209539251931L, new C1(), 0L, new C3(), new C2(), -128, new S0(2153262915U, -32767, new C0(), true, 387574144U)));
        C2 vr12 = vr11.F0.F4;
        System.Console.WriteLine(vr12.F0);
    }
}
