// Generated by Fuzzlyn on 2018-07-11 16:15:47
// Seed: 10302150359066586587
// Reduced from 41.6 KiB to 0.3 KiB
// Debug: Outputs 65519
// Release: Outputs 4294967279
public class Program
{
    public static void Main()
    {
        sbyte[] vr15 = new sbyte[]{-91};
        var vr17 = M6(vr15);
        ulong vr22 = vr17;
        System.Console.WriteLine(vr22);
    }

    static char M6(sbyte[] arg0)
    {
        return (char)(arg0[0] | 207);
    }
}
