// Generated by Fuzzlyn on 2018-06-04 00:11:20
// Seed: 6240856984534306668
// Reduced from 116.7 KB to 2.0 KB
// Debug: Runs successfully
// Release: Throws 'System.DivideByZeroException'
struct S0
{
    public uint F0;
    public ushort F1;
    public ulong F2;
    public ushort F3;
    public byte F4;
    public ushort F5;
    public byte F6;
    public short F7;
    public bool F8;
    public S0(uint f0, ushort f1, ulong f2, ushort f3, byte f4, ushort f5, byte f6, short f7, bool f8)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
        F5 = f5;
        F6 = f6;
        F7 = f7;
        F8 = f8;
    }
}

struct S1
{
    public S0 F0;
    public ulong F1;
    public uint F2;
    public byte F3;
    public short F4;
    public ushort F5;
    public char F6;
    public S0 F7;
    public S0 F8;
    public S0 F9;
    public S1(S0 f0, ulong f1, uint f2, byte f3, short f4, ushort f5, char f6, S0 f7, S0 f8, S0 f9)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
        F5 = f5;
        F6 = f6;
        F7 = f7;
        F8 = f8;
        F9 = f9;
    }
}

class C0
{
    public ulong F0;
    public uint F1;
    public short F2;
    public C0(uint f1, short f2)
    {
        F1 = f1;
        F2 = f2;
    }
}

class C1
{
    public long F2;
    public C1()
    {
    }
}

public class Program
{
    static C1 s_4 = new C1();
    public static void Main()
    {
        C0 vr63 = new C0(4294967295U, 0);
        vr63.F0 /= (((ulong)((uint)(158 / (vr63.F2 | 1)) / (vr63.F2 | 1)) / vr63.F1) | 1);
        var vr64 = s_4.F2++;
        var vr66 = new S1(new S0(3564611221U, 1, 18446744073709551614UL, 15582, 255, 42834, 1, -16816, true), 14850693075334100666UL, 4294967294U, 38, 1082, 25295, ' ', new S0(4064471828U, 29057, 3060851692309633772UL, 1, 81, 0, 28, -11029, false), new S0(0U, 12517, 1UL, 14276, 118, 65535, 17, 1572, true), new S0(3038306080U, 2274, 2752902496750962621UL, 31267, 1, 0, 218, 1, false));
        System.Console.WriteLine(vr66.F7.F1);
        sbyte[] vr65 = new sbyte[]{-13};
    }
}
