// Generated by Fuzzlyn on 2018-06-03 22:30:01
// Seed: 12513545373337062514
public class Program
{
    static uint s_1 = 3485803605U;
    static bool s_2 = true;
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        M1();
        if (true)
        {
            --s_1;
        }
        else
        {
            ushort var0 = 1;
        }

        if (true)
        {
            s_1 = (uint)M1();
            s_1 = s_1;
        }

        s_1 = s_1;
        if (true)
        {
            s_2 = s_2;
        }
    }

    static ushort M1()
    {
        s_1 = s_1;
        byte[] var0 = new byte[]{255, 1};
        var0[0] >>= 1935582549;
        s_1 = s_1--;
        ulong var1 = 1UL;
        return 14506;
    }
}