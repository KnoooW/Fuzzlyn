// Generated by Fuzzlyn on 2018-06-04 00:48:55
// Seed: 8441021430334718147
// Reduced from 114.6 KB to 1.7 KB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S0
{
    public short F0;
    public char F1;
    public bool F2;
    public ushort F3;
    public short F4;
    public short F5;
    public short F6;
    public ushort F7;
    public char F8;
    public S0(short f0, char f1, bool f2, ushort f3, short f4, short f5, short f6, ushort f7, char f8)
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

struct S2
{
    public ulong F0;
    public ulong F1;
    public char F2;
    public ulong F3;
    public uint F4;
    public bool F5;
    public byte F6;
    public ulong F7;
    public S0 F8;
    public S0 F9;
    public S2(ulong f0, ulong f1, char f2, ulong f3, uint f4, bool f5, byte f6, ulong f7, S0 f8, S0 f9)
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

public class Program
{
    static S2[] s_7 = new S2[]{new S2(2114896903171148104UL, 0UL, 'C', 7524759588663162212UL, 2594684235U, false, 1, 0UL, new S0(1, 'p', false, 0, -9568, 878, 0, 19964, 'X'), new S0(1, '_', true, 0, 26932, 1, 2981, 2795, 'l'))};
    static S2[, ] s_28 = new S2[, ]{{new S2(5846595529981325764UL, 11311360557156494053UL, '-', 8338964626583709931UL, 3822981355U, false, 199, 1UL, new S0(0, 'Z', true, 61299, 1, 273, -8353, 1979, 'o'), new S0(23081, 'R', false, 0, 1, 7599, 4260, 65535, 'Z'))}};
    public static void Main()
    {
        char vr121 = (char)((13897 / ((0 & s_28[0, 0].F4) | 1)) | M12(s_28[0, 0].F4));
    }

    static short M12(uint arg1)
    {
        short vr120 = s_7[0].F8.F4;
        return vr120;
    }
}
