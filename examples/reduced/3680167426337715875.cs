// Generated by Fuzzlyn v1.1 on 2018-08-27 21:06:14
// Seed: 3680167426337715875
// Reduced from 349.9 KiB to 0.9 KiB in 00:08:47
// Debug: Outputs True
// Release: Outputs False
struct S0
{
    public bool F0;
}

public class Program
{
    static sbyte[] s_41 = new sbyte[]{-1};
    static bool[] s_49 = new bool[]{true};
    static byte[] s_58;
    static S0 s_62;
    static S0 s_81;
    public static void Main()
    {
        M81(0, s_81);
    }

    static void M81(sbyte arg0, S0 arg1)
    {
        try
        {
            arg1 = new S0();
        }
        finally
        {
            arg0 = s_41[0];
            System.Console.WriteLine(s_62.F0);
            arg1 = new S0();
            sbyte var0 = arg0;
            s_62.F0 = var0 <= 0;
            System.Console.WriteLine(var0);
            s_49[0] = false;
            if (M82() < 0)
            {
                System.Console.WriteLine(s_58[0]);
            }
        }

        arg0 = arg0++;
    }

    static long M82()
    {
        System.Console.WriteLine(s_62.F0);
        return 0;
    }
}
