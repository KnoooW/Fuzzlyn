// Generated by Fuzzlyn on 2018-07-08 07:31:28
// Seed: 17082093613305531810
// Reduced from 4.2 KiB to 0.3 KiB
// Debug: Throws 'System.OverflowException'
// Release: Runs successfully
public class Program
{
    static long s_2;
    public static void Main()
    {
        M2(0);
    }

    static char M2(short arg0)
    {
        bool vr0 = 0 == (arg0-- % ((0 & (-9223372036854775808L % arg0)) | 1));
        return (char)s_2;
    }
}
