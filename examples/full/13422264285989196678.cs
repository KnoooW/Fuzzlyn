// Generated by Fuzzlyn on 2018-06-03 22:37:50
// Seed: 13422264285989196678
struct S0
{
    public ushort F0;
    public uint F1;
    public int F2;
    public byte F3;
    public char F4;
    public bool F5;
    public ulong F6;
    public sbyte F7;
    public S0(ushort f0, uint f1, int f2, byte f3, char f4, bool f5, ulong f6, sbyte f7)
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

struct S1
{
    public byte F0;
    public long F1;
    public sbyte F2;
    public byte F3;
    public ulong F4;
    public int F5;
    public byte F6;
    public short F7;
    public S1(byte f0, long f1, sbyte f2, byte f3, ulong f4, int f5, byte f6, short f7)
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
    static long[] s_1 = new long[]{9223372036854775806L, -10L, 0L, -1601484587449162404L};
    static long s_2 = 9223372036854775807L;
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        ulong var0 = 597112415212072342UL;
        s_1 = s_1;
        {
            {
                s_1 = new long[]{-9223372036854775808L};
                var0 = 1UL;
                if (false && false)
                {
                    var0 = var0;
                }
                else
                {
                    s_1 = new long[]{10L, 0L, 106453547653448052L};
                    var0 = var0;
                    S0 var1 = new S0(65534, 1U, -1149037937, 113, '/', true, 9466149229776229917UL, -22);
                    M1((long)M4(var0, new byte[]{25, 255, 173, 245, 0, 28, 0, 86}), var1.F2, 6822613448916087396L, var1.F6);
                    if (var1.F5)
                    {
                        var1.F7 = 127;
                        var1.F2 = var1.F2;
                    }
                    else
                    {
                        var1 = new S0(65535, 4294967295U, 2147483647, 1, '3', false, 14376856656308048897UL, -127);
                        return;
                    }
                }

                var0 = var0;
                s_1[0] = (long)('/' / (uint)((uint)M4(5078690120438119712UL, new byte[]{46, 254, 1, 223, 98, 78, 59, 242}) | 1));
            }

            char var2 = M2((ulong)M3());
            var2 = var2;
        }

        s_1 = s_1;
        s_1[0] = 0L;
    }

    static uint M1(long arg0, int arg1, long arg2, ulong arg3)
    {
        M2(arg3);
        return (uint)M4(arg3, new byte[]{133, 0, 210, 243});
    }

    static char M2(ulong arg0)
    {
        s_1[0] = s_1[0];
        s_1 = new long[]{-8524672404895243379L, -8869405783888232415L, 1L, 10L, 1L, 10L, 9223372036854775806L};
        s_2 = s_1[0];
        return M3();
    }

    static char M3()
    {
        M4(2781694071579592784UL, new byte[]{0, 247, 109, 62, 0, 95});
        return 'B';
    }

    static sbyte M4(ulong arg0, byte[] arg1)
    {
        {
            if (true)
            {
                arg0 = 0UL;
                s_1 = s_1;
            }

            short var0 = 32767;
            arg0 = 1UL;
            uint var1 = 3634586975U;
            s_1[0] = s_2;
            arg1 = new byte[]{1, 255, 246, 0, 1, 195, 118, 1};
        }

        M5((char)((ushort)(1 | arg1[0]) + 4002895151U), (sbyte)(1 * (sbyte)(6171 & M6())));
        return M6();
    }

    static S1 M5(char arg0, sbyte arg1)
    {
        arg1 = M6();
        arg0 = arg0;
        return new S1(0, 2088742237814428032L, -9, 125, 2137194690035800141UL, -2082485132, 198, 32766);
    }

    static sbyte M6()
    {
        S1 var0 = new S1(1, 8262121364835714745L, -49, 0, 18446744073709551614UL, -280871567, 1, 22899);
        return (sbyte)(var0.F7 | '}');
    }
}