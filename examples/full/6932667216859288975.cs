// Generated by Fuzzlyn on 2018-06-04 00:20:02
// Seed: 6932667216859288975
class C0
{
    public ulong F0;
    public int F1;
    public ushort F2;
    public long F3;
    public long F4;
    public byte F5;
    public short F6;
    public sbyte F7;
    public C0(ulong f0, int f1, ushort f2, long f3, long f4, byte f5, short f6, sbyte f7)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
        F5 = f5;
        F6 = f6;
        F7 = f7;
    }
}

public class Program
{
    static int[, ] s_1 = new int[, ]{{2147483647, -1227016018, -895648349, 1, 0, 0, 281565898, 2147483647}, {-1360631251, -163694541, 2, 0, -890441454, 10, -610309251, 1}, {677543701, 2147483647, 1702077576, 0, 174132906, 2125687795, 1993791967, 1546323127}, {1, -1979625983, 1182982245, 2147483646, -113822534, 0, 472343643, 0}, {-2147483647, 114955810, -1, 206769161, 1100711140, -1787009928, 1918034051, -1346337300}, {0, -380987435, 784611504, -452454930, 357139640, -1389473206, 0, 1741501946}, {-744196150, 2, 2147483646, -1695228125, -2, 476878617, 2147483647, 1382269195}, {-540609636, 1, 1725968752, 563696001, 0, 2, 2147483646, -10}};
    static sbyte s_2 = -71;
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        if ((char)(4106280861U & (char)(0 & (short)(2 & (uint)('a' ^ (-9223372036854775807L / (int)((255 % (sbyte)((sbyte)('l' * (ulong)(M1() - s_1[0, 0])) | 1)) | 1)))))) <= 0UL)
        {
            s_1[0, 0] = s_1[0, 0];
        }
        else
        {
            s_1[0, 0] /= (int)((int)((long)(0 & (short)M1()) * 4701158806419266428L) | 1);
            s_1[0, 0] = 1;
            s_1[0, 0] = (int)M1();
        }

        if (true)
        {
            s_1[0, 0] = 2147483647;
            s_2 = s_2;
            s_1[0, 0] = s_1[0, 0]--;
        }

        s_2 = (sbyte)((char)M1() * s_2);
    }

    static byte M1()
    {
        s_1 = new int[, ]{{-2147483647, 0, -2, -2029973297, 794772576, 10}};
        return 255;
    }
}