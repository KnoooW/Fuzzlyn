// Generated by Fuzzlyn on 2018-06-03 22:30:52
// Seed: 12657685807435370041
struct S0
{
    public short F0;
    public short F1;
    public byte F2;
    public bool F3;
    public bool F4;
    public byte F5;
    public S0(short f0, short f1, byte f2, bool f3, bool f4, byte f5)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
        F5 = f5;
    }
}

class C0
{
    public int F0;
    public long F1;
    public uint F2;
    public ushort F3;
    public long F4;
    public S0 F5;
    public long F6;
    public bool F7;
    public int F8;
    public C0(int f0, long f1, uint f2, ushort f3, long f4, S0 f5, long f6, bool f7, int f8)
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

class C1
{
    public C0 F0;
    public C1(C0 f0)
    {
        F0 = f0;
    }
}

public class Program
{
    static C0[, ] s_1 = new C0[, ]{{new C0(714916187, 2919505232530466089L, 2133670997U, 22246, 3601866675313591440L, new S0(-19044, 1, 0, false, true, 194), -3082640883353377342L, true, 1086847268)}, {new C0(2, 9223372036854775807L, 1012578078U, 0, 0L, new S0(2, -10899, 241, true, false, 55), 9223372036854775807L, false, -1923209303)}, {new C0(0, 1414716276200434759L, 4294967294U, 0, -2481863072536186240L, new S0(-30021, 3994, 1, true, false, 62), 8317423147527043458L, true, -1108695964)}, {new C0(464117814, -6896731560754802726L, 0U, 22238, 1L, new S0(-32768, -30519, 1, false, true, 213), -9223372036854775808L, true, 2147483647)}, {new C0(0, 4258864772132783682L, 0U, 31489, 462622228957694950L, new S0(0, -15338, 165, false, false, 1), -2165576696283378080L, false, -14492153)}, {new C0(1900678353, -9223372036854775808L, 0U, 1, -9223372036854775807L, new S0(-32767, 32767, 253, true, true, 254), -9223372036854775807L, false, 2147483646)}, {new C0(1188318316, 2967604316467707527L, 2U, 1, 77134870673099202L, new S0(32766, -9015, 255, false, true, 0), 9223372036854775807L, false, -1163558660)}, {new C0(-1984529631, 1928451693590181871L, 10U, 0, -917686711289484751L, new S0(1, 0, 0, false, false, 129), 10L, true, 963813348)}, {new C0(-2147483647, -5873508968455045762L, 395164563U, 0, 2152134057549404230L, new S0(-21229, -1, 254, false, true, 1), -1204026807599939897L, true, 1)}};
    static long s_2 = 9223372036854775806L;
    static char[, ][] s_3 = new char[, ][]{{new char[]{'x'}}, {new char[]{'!'}}, {new char[]{'*', '$', '-'}}, {new char[]{'[', 'C'}}, {new char[]{'i', 'g', 'h', 'f'}}, {new char[]{'h'}}, {new char[]{'$', 'l', 'j', 'o'}}, {new char[]{'w', 'w', '%'}}, {new char[]{'*', 'P', 'n'}}, {new char[]{'T'}}};
    static short s_4 = 24248;
    static long s_5 = 7841083357246476367L;
    static int s_6 = 452967840;
    static char s_7 = '>';
    static ulong s_8 = 492887416979047966UL;
    static ushort[] s_9 = new ushort[]{0, 23258, 24315, 65339, 1, 0};
    static char s_10 = '=';
    static long[] s_11 = new long[]{9223372036854775806L, 4499662513565757955L, 3319121913853646937L};
    static short[] s_12 = new short[]{32766, -17070, 1, 5322, 0, -12333, 1, -1, -20160, 24596};
    static ushort s_13 = 18820;
    static bool s_14 = false;
    static long s_15 = 1L;
    static ushort s_16 = 41943;
    static byte[] s_17 = new byte[]{1, 0, 255, 1, 0};
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        if (true)
        {
            ushort var0 = 2;
            var0 = var0;
            var0 = var0;
            var0 = var0;
            var0 = (ushort)(1U * (-2 * (short)((byte)(0UL * (ulong)('R' * (byte)((uint)(0L | (short)(-2147483647 / (uint)((uint)('X' % (int)(M1(s_13, (ushort)M8('Q', new C1(new C0(2147483646, 9039217647735804182L, 2332673108U, 1, 2019020437742678743L, new S0(-15116, 32767, 255, false, false, 0), 9223372036854775807L, true, 1))), s_7, s_8) | 1)) | 1))) / (uint)((uint)(s_1[0, 0].F5.F2 - (char)M15()) | 1)))) * (sbyte)(s_7 | s_1[0, 0].F8++))));
            s_1[0, 0].F3 = 23550;
        }
        else
        {
            s_1[0, 0].F1 = s_1[0, 0].F6;
        }
    }

    static int M1(ushort arg0, ushort arg1, char arg2, ulong arg3)
    {
        if (M2(true))
        {
            if (M5())
            {
                s_1[0, 0].F1 = s_15;
                s_16 = arg0--;
                s_1[0, 0].F1 = s_1[0, 0].F1;
            }

            s_1[0, 0] = s_1[0, 0];
            s_1[0, 0].F6 = (long)M9();
            {
                M6(arg3);
                s_17 = s_17;
                s_1[0, 0].F5.F4 = s_1[0, 0].F7;
                s_1[0, 0].F8 = s_1[0, 0].F8++;
            }

            s_8 = arg3;
            s_1[0, 0].F5.F3 = true;
        }

        s_13 = M7(s_12[0]++, (long)(-15960 ^ s_3[0, 0][0]));
        M2(false);
        s_1[0, 0].F8 = s_1[0, 0].F0;
        return s_6;
    }

    static bool M2(bool arg0)
    {
        int var0 = 72235446;
        C0 var1 = new C0(0, 10L, 1U, 23598, -850409604905153043L, new S0(1, 2, 83, true, true, 1), -7242373567340958443L, true, -2147483648);
        M3();
        if (s_14)
        {
            s_15 = s_5;
            bool[, ] var2 = new bool[, ]{{false, true, false, true, false, false, false, false}, {false, true, true, true, true, false, true, false}, {false, true, true, true, true, true, true, false}, {true, false, false, false, false, false, false, true}, {true, false, true, true, false, true, true, true}, {true, false, true, false, false, false, true, true}, {true, true, true, true, true, true, true, true}, {true, true, true, false, true, false, false, true}};
            ulong var3 = 0UL;
            if (M5())
            {
                if (true)
                {
                    if (M5())
                    {
                        var2 = new bool[, ]{{true, true, true, true, false, true, false}, {true, true, false, true, false, false, false}, {false, true, true, false, false, true, false}, {true, true, false, false, true, false, false}, {false, false, false, true, false, true, true}, {true, false, false, true, true, false, true}, {false, false, false, false, true, false, false}, {true, true, false, false, true, true, true}};
                    }

                    s_16 = var1.F3;
                    s_1[0, 0].F5.F3 = false;
                    var0 = s_1[0, 0].F8++;
                    s_1[0, 0].F5.F2 = (byte)M12();
                    if (true)
                    {
                        {
                            s_2 /= (long)(s_15 | 1);
                        }

                        C0 var4 = s_1[0, 0];
                        C1 var5 = new C1(new C0(2147483647, 5471160003512329447L, 4294967295U, 10, 6566592597454298482L, new S0(-10, 32767, 254, true, false, 1), -9223372036854775807L, false, -71137577));
                        M15();
                        s_13 = s_16;
                        return var4.F5.F3;
                    }
                    else
                    {
                        ushort var6 = s_13;
                        {
                            s_1[0, 0].F5.F3 = M5();
                        }
                    }

                    M9();
                    s_1[0, 0] = new C0(698631307, -10L, 1891438386U, 40948, 3028662890246042004L, new S0(1, 1, 111, true, false, 111), -6815967502550691675L, true, -2147483648);
                    var1.F5 = s_1[0, 0].F5;
                }

                s_9 = s_9;
                s_1[0, 0].F2 = s_1[0, 0].F2++;
                var3 = var3;
            }
        }

        if (true)
        {
            s_13 = M15();
        }

        return s_1[0, 0].F5.F3;
    }

    static int[] M3()
    {
        if (true & (2421168977937164031L > '{'))
        {
            ushort var0 = 33725;
        }

        uint[] var1 = new uint[]{819065592U, 599121904U, 3383070283U, 2085393697U, 2423612577U};
        if ('?' < (int)(537366316U % (ushort)(M4((sbyte)(s_5 + s_1[0, 0].F5.F0)) | 1)))
        {
            if (false)
            {
                s_3[0, 0][0] = (char)M9();
                s_8 = 16944817079004079829UL;
                s_1[0, 0].F5.F4 = M5();
                M15();
                ulong var2 = (ulong)(-10L % (char)(s_7 | 1));
            }
            else
            {
                if (false)
                {
                    s_1[0, 0].F5.F3 = true;
                    s_3 = s_3;
                    short var3 = s_1[0, 0].F5.F0;
                    M10();
                    s_2 = s_1[0, 0].F4;
                    if (M5())
                    {
                        s_3[0, 0][0] = s_3[0, 0][0];
                        var1[0] = var1[0];
                    }
                }

                s_8 = s_8;
                s_1[0, 0].F6 = s_1[0, 0].F4;
                if (s_1[0, 0].F5.F4)
                {
                    s_6 = (int)M8(s_7, new C1(new C0(754297232, -7327184488502609756L, 1765210937U, 12140, 1L, new S0(23609, -32767, 159, true, true, 1), 0L, false, 0)));
                    s_8 = 5611029694871768845UL;
                    if (true)
                    {
                        s_3[0, 0] = s_3[0, 0];
                        s_10 = s_10;
                        {
                            M11(var1[0]);
                        }
                    }
                }
            }
        }
        else
        {
            if (s_1[0, 0].F5.F4)
            {
                if (s_1[0, 0].F5.F3)
                {
                    if (s_1[0, 0].F7)
                    {
                        M15();
                    }
                    else
                    {
                        C1 var4 = new C1(new C0(1386041293, 2712914609893251638L, 1452467896U, 51025, -1452474475066183403L, new S0(-30049, 0, 226, true, true, 1), -3590789903408108025L, true, 1));
                        {
                            if (false)
                            {
                                var4.F0.F5 = s_1[0, 0].F5;
                            }
                            else
                            {
                                var4.F0.F5.F0 = s_1[0, 0].F5.F0;
                            }
                        }
                    }
                }
                else
                {
                    byte var5 = 10;
                    {
                        s_11 = s_11;
                        s_3 = s_3;
                    }
                }

                byte[] var6 = new byte[]{1, 1, 30, 123, 86};
                M15();
                s_10 = s_10;
                s_3 = new char[, ][]{{new char[]{'J'}}, {new char[]{')', 'C', '~', '<', 'm', 'i', 'X', 'N', ']'}}, {new char[]{'[', 'E'}}};
                s_3[0, 0] = new char[]{'#', ';', 'U', 'L'};
            }
        }

        {
            s_1 = new C0[, ]{{new C0(2147483647, -9223372036854775807L, 1U, 28982, 9223372036854775806L, new S0(1, 22839, 81, true, true, 255), -4479109322054320194L, false, 1838079140), new C0(2147483646, 9223372036854775806L, 1878955808U, 1554, 4609824821346423030L, new S0(1, -16254, 1, false, true, 14), 1L, true, 821464385), new C0(0, 1L, 2451000771U, 47285, -827417585881090051L, new S0(21384, -9937, 74, true, false, 0), -5566981083015836534L, false, -1303275883)}, {new C0(1616106378, -137650967606378884L, 4294967295U, 10, 1L, new S0(32766, 0, 1, false, true, 16), 3683036273517323099L, true, 0), new C0(1, 9223372036854775806L, 0U, 17618, 6157172670863344664L, new S0(-2788, 32767, 1, true, false, 1), -1L, false, 1627429467), new C0(-2147483648, 353550804897516266L, 4294967295U, 54614, -8208208636425478311L, new S0(0, -32768, 0, true, true, 1), -9223372036854775807L, false, 2147483646)}, {new C0(1, -1130649139702765872L, 1U, 65535, 5232018114979948237L, new S0(32766, 22388, 0, true, false, 173), 4531674224401952023L, true, -1356649986), new C0(-20130907, -3463106446173222910L, 1571627653U, 909, 9223372036854775806L, new S0(20823, 5345, 27, true, true, 0), 9223372036854775807L, false, -2147483648), new C0(2147483647, -9223372036854775808L, 3611446773U, 43629, -9036219847641599177L, new S0(-15051, -32768, 1, false, false, 1), 8678834810501253275L, false, -1787083218)}, {new C0(-2085218793, -4968399824524937645L, 3134797033U, 1, -2L, new S0(-28722, 0, 1, true, false, 10), -10L, true, 382736736), new C0(-1096541058, -587572733802473974L, 75128788U, 53393, 5357391288746354636L, new S0(-10687, -32768, 0, true, true, 213), -5883593209062877010L, true, 0), new C0(1939202308, 0L, 4217230282U, 8890, -4765592703160663702L, new S0(-5412, 32766, 0, true, true, 2), -4024339286529737583L, true, 2)}, {new C0(195146536, -8852889619036796449L, 0U, 9690, -9038335068160164377L, new S0(0, -2, 85, true, true, 1), 6617545118044492471L, true, 1538934662), new C0(737254641, 7557214838084642233L, 0U, 1, -9118715334880456226L, new S0(0, -13211, 254, false, false, 165), 1L, true, -10), new C0(-67563736, -8256772772433279920L, 1U, 2, 10L, new S0(1, 8669, 0, true, true, 218), -322205393794433747L, false, 0)}, {new C0(-533339871, 8378239305143587561L, 1U, 52212, 1L, new S0(0, -28188, 150, false, true, 0), -9223372036854775807L, true, -792342144), new C0(589769692, -7669209890313662684L, 4294967294U, 2, -1992458246154687084L, new S0(0, 0, 191, false, false, 187), 9223372036854775807L, false, -2), new C0(1, 9223372036854775807L, 932297324U, 55236, -9218216488092252526L, new S0(-949, -6873, 245, false, true, 206), 4675661399720073799L, true, 588568141)}};
            if (true)
            {
                S0 var7 = s_1[0, 0].F5;
                s_12 = s_12;
                M6(0UL);
                s_1[0, 0].F7 = s_1[0, 0].F5.F4;
                s_1[0, 0].F8 = (int)M9();
            }
            else
            {
                s_1[0, 0].F7 = s_1[0, 0].F7;
                {
                    s_1[0, 0].F5.F2 = s_1[0, 0].F5.F2;
                    M9();
                }

                s_6 = s_1[0, 0].F8;
                ushort var8 = s_9[0];
                if (s_1[0, 0].F5.F3)
                {
                    s_1[0, 0].F5.F4 = true;
                }
                else
                {
                    s_3[0, 0] = s_3[0, 0];
                    s_12 = s_12;
                    s_4 = s_12[0];
                    s_1[0, 0].F5.F3 = false;
                }
            }

            s_5 = s_2;
            s_13 = (ushort)((short)M8(s_3[0, 0][0], new C1(new C0(0, 1L, 2U, 1, 2L, new S0(-20308, 32767, 177, true, true, 0), 7219910809332704322L, false, 1364364422))) + s_1[0, 0].F5.F1);
            s_14 = s_1[0, 0].F5.F3;
            s_5 = s_5--;
            {
                sbyte var9 = M8((char)M6(s_8), new C1(new C0(-993667737, 1L, 1U, 33271, 0L, new S0(-32768, 17269, 1, false, true, 0), 9223372036854775806L, false, 943191500)));
            }

            bool var10 = true;
            s_2 = 0L;
        }

        return new int[]{2147483646, 0, 2, 2147483646, 2147483647, 208413078, -1112496883};
    }

    static ushort M4(sbyte arg0)
    {
        if (M5())
        {
            ushort var0 = s_1[0, 0].F3;
            int var1 = s_1[0, 0].F0;
            if (s_1[0, 0].F7)
            {
                s_1[0, 0].F5.F5 = s_1[0, 0].F5.F5--;
                if (false)
                {
                    M7(s_1[0, 0].F5.F1--, s_1[0, 0].F4);
                    M7(s_1[0, 0].F5.F0, s_2);
                }

                bool var2 = true;
                M6((ulong)(s_2 + s_1[0, 0].F2--));
                s_1[0, 0].F5 = new S0(-10, 32766, 189, true, true, 0);
                {
                    return s_1[0, 0].F3++;
                }

                byte var3 = s_1[0, 0].F5.F5;
            }

            byte[] var4 = new byte[]{1, 12, 1, 0};
            if (false)
            {
                char[] var5 = new char[]{'u', '{', 'b', 'W', 'q', ']', ','};
                s_1[0, 0].F2 += M6((ulong)(s_1[0, 0].F3 % (long)(1L | 1)));
            }
            else
            {
                if (false)
                {
                    s_1[0, 0].F5.F4 |= s_1[0, 0].F5.F4;
                    s_1[0, 0].F5.F4 = s_1[0, 0].F7;
                }
                else
                {
                    S0 var6 = s_1[0, 0].F5;
                    if (true)
                    {
                        --s_1[0, 0].F3;
                        s_1[0, 0].F5.F2 = s_1[0, 0].F5.F2;
                    }
                }

                byte var7 = s_1[0, 0].F5.F5;
            }

            {
                s_1[0, 0].F5.F1 = (short)M6(15331006188799765444UL);
            }

            s_1[0, 0].F7 = M5();
        }
        else
        {
            if (M5())
            {
                if (s_1[0, 0].F5.F3)
                {
                    s_1[0, 0].F3 = 36623;
                    if (s_1[0, 0].F5.F4 == false)
                    {
                        char var8 = '$';
                    }
                }

                if (s_1[0, 0].F5.F3)
                {
                    return s_1[0, 0].F3--;
                }
                else
                {
                    ushort var9 = s_1[0, 0].F3++;
                }

                s_1[0, 0].F4 = s_1[0, 0].F2-- - M8('[', new C1(new C0(2147483646, 1535836752284499038L, 4294967295U, 0, 1L, new S0(6184, 12398, 211, true, false, 0), 8609271103569675864L, true, 1)));
                s_1[0, 0].F5.F0 = s_1[0, 0].F5.F0;
                s_1[0, 0].F3 = s_1[0, 0].F3;
            }
            else
            {
                int var10 = (int)M6(s_8);
                s_6 = (int)M6((ulong)M9());
                {
                    M15();
                    if (s_1[0, 0].F5.F4)
                    {
                        s_1[0, 0].F0 = s_1[0, 0].F8;
                        s_1[0, 0].F3 = (ushort)(s_9[0] ^ (uint)M15());
                        {
                            s_1[0, 0].F4 = s_5;
                        }

                        if (s_1[0, 0].F5.F4)
                        {
                            byte var11 = 0;
                        }
                    }
                    else
                    {
                        uint var12 = s_1[0, 0].F2++;
                        s_1[0, 0].F5.F3 ^= s_1[0, 0].F5.F4;
                    }

                    M9();
                    int var13 = var10;
                    s_5 = s_1[0, 0].F1;
                    s_1[0, 0].F5.F5 = (byte)(13 + s_1[0, 0].F2--);
                }
            }

            ushort var14 = 12952;
            s_6 = s_1[0, 0].F0;
            ushort var15 = s_1[0, 0].F3;
        }

        s_8 = s_8;
        return (ushort)M8(s_7, new C1(new C0(-1542887255, -492163188611659606L, 4294967294U, 1, 0L, new S0(32767, 1, 0, true, false, 0), -4006518909882323926L, true, -1537146811)));
    }

    static bool M5()
    {
        s_1 = s_1;
        {
            s_1[0, 0].F5 = s_1[0, 0].F5;
            if (true)
            {
                s_1 = s_1;
            }
            else
            {
                s_1[0, 0].F5.F4 = s_1[0, 0].F7;
                s_1[0, 0].F4 = s_1[0, 0].F4;
                s_1[0, 0].F6 = s_1[0, 0].F4;
                s_2 = -3448205033194433395L;
                {
                    M6((ulong)((char)M7(s_1[0, 0].F5.F1, s_2) / (short)((short)((byte)(s_1[0, 0].F3 ^ (byte)(s_1[0, 0].F8-- - 65535)) % (short)(s_1[0, 0].F5.F1 | 1)) | 1)));
                    s_1[0, 0].F7 = (uint)M7((short)M6(18446744073709551615UL), s_1[0, 0].F6) != 64186;
                    s_1[0, 0].F4 = s_1[0, 0].F4;
                }

                s_1[0, 0].F5 = new S0(-32768, 9448, 194, true, false, 1);
            }

            s_2 = (long)(s_1[0, 0].F3 | (sbyte)M7(s_1[0, 0].F5.F0, 0L));
        }

        s_1[0, 0].F5.F3 = s_1[0, 0].F5.F3;
        s_1[0, 0].F5.F4 = s_1[0, 0].F5.F3;
        s_1[0, 0].F5.F1 = -10175;
        return s_1[0, 0].F5.F4;
    }

    static uint M6(ulong arg0)
    {
        M7(2, 9223372036854775807L);
        C0 var0 = s_1[0, 0];
        M7(s_1[0, 0].F5.F1, 0L);
        M7(var0.F5.F1, s_1[0, 0].F1 & s_1[0, 0].F0);
        return (uint)M7(var0.F5.F1--, s_2);
    }

    static ushort M7(short arg0, long arg1)
    {
        s_1[0, 0].F5.F5 = s_1[0, 0].F5.F5;
        return 1;
    }

    static sbyte M8(char arg0, C1 arg1)
    {
        short var0 = arg1.F0.F5.F1;
        s_1[0, 0].F3 = arg1.F0.F3;
        arg1.F0.F2 = arg1.F0.F2;
        if (s_1[0, 0].F5.F4)
        {
            s_1[0, 0].F7 = 6210609011012292003UL < M9();
            s_6 = 1;
        }
        else
        {
            if (arg1.F0.F7)
            {
                if (false)
                {
                    M15();
                }
            }

            arg1.F0.F5 = s_1[0, 0].F5;
            arg1.F0.F5.F1 = s_4++;
        }

        if ((long)M9() != 'T')
        {
            C0 var1 = new C0(771559885, 9223372036854775807L, 1U, 65535, 0L, new S0(3619, -9549, 1, true, false, 1), 9223372036854775807L, true, 1654639135);
        }
        else
        {
            s_3[0, 0] = s_3[0, 0];
        }

        s_5 = s_1[0, 0].F6;
        arg1.F0.F5.F4 = arg1.F0.F5.F3;
        byte var2 = arg1.F0.F5.F5;
        return 32;
    }

    static uint M9()
    {
        {
            {
                s_1[0, 0].F7 = s_1[0, 0].F5.F4;
            }

            if (true)
            {
                s_1[0, 0] = s_1[0, 0];
                s_1[0, 0].F5 = new S0(0, -1, 198, false, false, 145);
            }
            else
            {
                s_2 = s_1[0, 0].F4;
                s_1[0, 0].F5 = s_1[0, 0].F5;
            }

            M10();
            C1 var0 = new C1(new C0(1950897787, 2067071838688348782L, 0U, 1048, -9223372036854775807L, new S0(-32767, -1, 18, true, true, 151), 2515418467863977151L, true, -650341226));
            {
                if (s_1[0, 0].F5.F4)
                {
                    byte var1 = var0.F0.F5.F5;
                    {
                        bool var2 = 'm' < (18446744073709551615UL / (uint)((uint)('t' | var0.F0.F8) | 1));
                    }
                }
                else
                {
                    var0.F0 = M11(s_1[0, 0].F2);
                    var0.F0.F8 = s_1[0, 0].F0;
                }

                if (s_1[0, 0].F5.F3)
                {
                    var0.F0 = new C0(-2147483648, 1L, 1321001918U, 0, -9223372036854775808L, new S0(1, 32766, 250, false, true, 0), -1389631703267781960L, false, 1);
                    if (s_1[0, 0].F7)
                    {
                        if (s_1[0, 0].F5.F4)
                        {
                            if (s_1[0, 0].F7)
                            {
                                {
                                    bool var3 = s_1[0, 0].F5.F3;
                                }

                                s_1[0, 0].F5.F2 = s_1[0, 0].F5.F2;
                            }

                            s_1[0, 0].F5 = var0.F0.F5;
                            s_7++;
                        }
                        else
                        {
                            var0.F0.F3 = 1;
                        }

                        s_1[0, 0].F3 = var0.F0.F3;
                    }
                }

                s_1[0, 0].F1 = var0.F0.F4--;
                {
                    if (s_1[0, 0].F5.F4)
                    {
                        s_1[0, 0].F0 = s_1[0, 0].F8;
                        if (true)
                        {
                            s_1[0, 0].F5.F4 = false;
                        }

                        var0.F0.F8 = 2147483646;
                        s_1[0, 0] = var0.F0;
                        s_6 = (int)M12();
                        var0.F0.F5.F2 = 219;
                        var0 = var0;
                        var0.F0.F5.F5++;
                    }
                    else
                    {
                        var0.F0.F5.F2 = var0.F0.F5.F5;
                        if (false)
                        {
                            var0.F0.F5.F0 = s_4;
                        }
                    }

                    s_1[0, 0].F5.F2 ^= var0.F0.F5.F5--;
                    ushort var4 = (ushort)(5433135920157739730L % (uint)(s_1[0, 0].F2 | 1));
                    s_1[0, 0] = s_1[0, 0];
                    M13();
                    S0 var5 = new S0(-32767, 0, 1, false, false, 255);
                    long var6 = s_2;
                    var0.F0.F5.F1 = var0.F0.F5.F0;
                    var0.F0.F5.F5 = s_1[0, 0].F5.F5;
                    var0.F0.F5.F3 = false;
                    if (var5.F3)
                    {
                        var0.F0.F5.F4 = true;
                        s_1[0, 0] = s_1[0, 0];
                        var0.F0.F5.F3 = s_1[0, 0].F5.F4;
                        bool var7 = true;
                    }
                    else
                    {
                        M14(s_1[0, 0].F8, new bool[]{false, true, true, false, false, false, false, false, true, false}, s_1[0, 0].F0);
                    }

                    var5.F1 = var5.F0;
                    short var8 = -2;
                    var0.F0.F5.F2 = var0.F0.F5.F5;
                    var0.F0.F2 = var0.F0.F2--;
                    var0.F0.F7 = true != true;
                    long var9 = 9223372036854775806L;
                    s_8 = 17238317725622750970UL;
                }

                if (s_1[0, 0].F5.F3)
                {
                    int var10 = s_1[0, 0].F0;
                }
                else
                {
                    M13();
                }

                var0.F0.F5.F2 = s_1[0, 0].F5.F2;
                s_7 = M12();
                if ((uint)M15() < (ushort)(s_1[0, 0].F0 ^ s_1[0, 0].F3))
                {
                    var0.F0.F2 = var0.F0.F2;
                }
                else
                {
                    s_1[0, 0].F8 = var0.F0.F8;
                    M12();
                    if (true)
                    {
                        {
                            var0.F0.F0 = var0.F0.F5.F0++ ^ s_1[0, 0].F5.F1;
                        }

                        S0[][] var11 = new S0[][]{new S0[]{new S0(31697, -32768, 97, false, true, 145), new S0(32766, 17670, 207, false, true, 0)}, new S0[]{new S0(16410, 11106, 173, true, false, 1), new S0(-28074, 32766, 0, true, false, 1)}, new S0[]{new S0(-20229, 4262, 1, false, true, 1), new S0(-25116, -32355, 60, false, false, 255)}, new S0[]{new S0(-1539, -6316, 229, true, true, 254), new S0(-10, 26996, 11, true, false, 255), new S0(28299, 2, 0, false, false, 232)}};
                    }
                }
            }

            s_9 = new ushort[]{34903, 0, 39832, 35942, 61169, 65534, 19145, 0, 63937, 19148};
        }

        return 1U;
    }

    static ulong[] M10()
    {
        if (s_1[0, 0].F5.F3)
        {
            s_1[0, 0].F5.F1 = s_1[0, 0].F5.F1;
            if (true)
            {
                s_1[0, 0].F5.F1 = s_1[0, 0].F5.F1++;
                s_2 = 9223372036854775806L;
            }

            s_1[0, 0].F7 = false;
        }
        else
        {
            if (s_1[0, 0].F5.F4)
            {
                s_1[0, 0].F5.F4 = false;
                if (s_1[0, 0].F7)
                {
                    ushort var0 = s_1[0, 0].F3;
                }
                else
                {
                    s_1[0, 0] = new C0(-2147483647, -6395411784019608137L, 3084780138U, 19288, 9223372036854775807L, new S0(0, 28306, 1, true, false, 195), 9223372036854775807L, true, -265875401);
                }

                if (s_1[0, 0].F5.F4)
                {
                    s_1[0, 0].F4 = s_1[0, 0].F6--;
                }
            }
        }

        return new ulong[]{11817707119290384058UL, 18446744073709551614UL};
    }

    static C0 M11(uint arg0)
    {
        if (s_1[0, 0].F7)
        {
            s_1[0, 0].F6 = s_1[0, 0].F4;
        }
        else
        {
            if (true)
            {
                s_1[0, 0].F5.F5 = s_1[0, 0].F5.F2;
                arg0 = (uint)(0 & s_1[0, 0].F5.F1);
            }
            else
            {
                s_1[0, 0].F3 = s_1[0, 0].F3++;
                {
                    {
                        if (s_1[0, 0].F7)
                        {
                            if (s_1[0, 0].F7)
                            {
                                s_1[0, 0].F8 = s_1[0, 0].F0;
                            }
                        }

                        M12();
                        M12();
                        s_1 = s_1;
                    }
                }

                long var0 = s_1[0, 0].F4;
                var0 = 2L;
            }

            s_1[0, 0].F5.F3 = s_1[0, 0].F5.F3;
            if (650143782U < -1108088683)
            {
                if (false)
                {
                    if (s_1[0, 0].F5.F3)
                    {
                        s_1[0, 0].F5.F3 = s_1[0, 0].F7;
                        s_3 = s_3;
                    }
                    else
                    {
                        s_1[0, 0].F8 = s_1[0, 0].F8;
                        M12();
                    }

                    ++s_4;
                }
                else
                {
                    M12();
                    s_3[0, 0] = s_3[0, 0];
                }

                s_1[0, 0].F1 = s_1[0, 0].F1;
                s_1[0, 0].F4 = 1L;
                {
                    s_5 = s_5;
                    s_3[0, 0][0] = s_3[0, 0][0];
                    if (s_1[0, 0].F5.F4)
                    {
                        s_1[0, 0].F4 = s_1[0, 0].F6--;
                        if (s_1[0, 0].F7)
                        {
                            s_1[0, 0].F1 = s_5;
                            M12();
                            bool var1 = s_1[0, 0].F7;
                        }

                        s_1[0, 0].F2 = 2160746323U;
                        s_1[0, 0].F5.F1 = s_1[0, 0].F5.F0;
                    }
                    else
                    {
                        s_1[0, 0].F4 = s_1[0, 0].F1;
                        M12();
                        {
                            {
                                bool[] var2 = new bool[]{false, false, false};
                            }
                        }

                        M12();
                        s_1[0, 0].F3 = s_1[0, 0].F3;
                    }
                }

                if (s_1[0, 0].F5.F4)
                {
                    s_6 = 1372663521;
                }
                else
                {
                    s_1[0, 0].F0 ^= (int)M12();
                }

                uint var3 = s_1[0, 0].F2;
            }

            s_1 = new C0[, ]{{new C0(-2147483648, 684638598848836072L, 494190733U, 23671, 1L, new S0(-32767, 32767, 46, true, false, 0), 1705245107309900277L, true, 2147483647), new C0(1472845541, 3593066836894796892L, 4294967294U, 1, -2006808460201759803L, new S0(0, 32767, 1, false, true, 0), 9223372036854775806L, false, 369729801), new C0(2147483646, -7161405734066158638L, 1690917426U, 0, -5352681589300399934L, new S0(-32767, 30853, 1, false, true, 236), 0L, true, -2147483647), new C0(1278917634, 1L, 0U, 58670, 448344282164890859L, new S0(1, 1, 0, true, true, 239), 9223372036854775807L, true, -2147483647), new C0(-1349130457, 1L, 1043059419U, 13726, 6196320589112838797L, new S0(17334, -22226, 41, false, true, 2), 1L, true, -2147483648), new C0(2, -7045451508946283105L, 0U, 54431, 1205293378811157757L, new S0(1, 1, 255, true, false, 233), -10L, false, 10), new C0(1411280045, 9223372036854775807L, 2U, 65535, -4033204848630912050L, new S0(-25458, -15387, 134, true, true, 133), 1L, false, 1052273535)}};
            s_1[0, 0].F5 = s_1[0, 0].F5;
        }

        return M13();
    }

    static char M12()
    {
        long[] var0 = new long[]{-9223372036854775807L};
        return 'L';
    }

    static C0 M13()
    {
        if (s_1[0, 0].F7)
        {
            s_3[0, 0][0] = s_3[0, 0][0];
            s_4 = s_1[0, 0].F5.F0;
            s_4 = -25762;
            if (s_1[0, 0].F5.F3)
            {
                s_1[0, 0].F2 = 493039690U;
                M14(s_6, new bool[]{false, false, false, false}, -87231250);
                M15();
            }

            s_1[0, 0].F1 &= -5196492370713514237L;
            return s_1[0, 0];
        }
        else
        {
            s_1[0, 0].F3 = 65534;
            s_2 = (long)M15();
            s_1[0, 0].F5.F5 = s_1[0, 0].F5.F5;
        }

        s_2 = s_5;
        return new C0(-842815425, 9223372036854775806L, 3391505793U, 0, 0L, new S0(32766, -32768, 152, true, false, 10), 0L, false, -1585213709);
    }

    static C0[] M14(int arg0, bool[] arg1, int arg2)
    {
        s_1[0, 0].F6 = s_1[0, 0].F1;
        s_6 = s_1[0, 0].F0;
        return new C0[]{new C0(-2147483648, -9117741978320281225L, 2305021092U, 22198, 1L, new S0(1, 32767, 2, false, true, 81), 9223372036854775806L, true, 0), new C0(272190819, 1L, 1U, 65534, -1640423209145767902L, new S0(29269, -17284, 161, false, false, 76), 1649605092356567671L, false, -787764629), new C0(-2147483647, -2L, 1863533712U, 65535, -3277591065059186752L, new S0(32766, 0, 1, true, false, 1), -4778978880038041952L, false, 1852177158), new C0(-2, 2774903016548132100L, 3929490002U, 1, 9223372036854775806L, new S0(0, 0, 152, false, false, 1), -9223372036854775807L, true, -1469385544), new C0(2147483646, -4134055828791919347L, 2U, 28658, 0L, new S0(32766, -32767, 141, false, false, 1), -7085188943634715434L, false, -225781860), new C0(1, 1L, 0U, 60780, 9223372036854775806L, new S0(0, -32767, 35, true, true, 81), -9223372036854775807L, false, -702872576)};
    }

    static ushort M15()
    {
        s_1[0, 0].F0 -= 0;
        return 1;
    }
}