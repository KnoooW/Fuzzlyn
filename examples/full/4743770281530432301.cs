// Generated by Fuzzlyn on 2018-06-03 23:54:21
// Seed: 4743770281530432301
public class Program
{
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        ushort[] var0 = new ushort[]{38619, 0, 0, 46369, 0};
        long var1 = 189 * (long)(16710 | (sbyte)((int)(4294967294U * var0[0]) / (short)(-32768 | 1)));
        var1 = var1++;
    }
}