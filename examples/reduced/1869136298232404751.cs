// Generated by Fuzzlyn on 2018-06-03 23:29:18
// Seed: 1869136298232404751
// Reduced from 44.9 KB to 0.3 KB
// Debug: Outputs 56
// Release: Outputs -200
public class Program
{
    static sbyte s_3 = -100;
    public static void Main()
    {
        M8(s_3);
    }

    static long M8(sbyte arg0)
    {
        var vr6 = arg0++ + (byte)(1U ^ arg0);
        System.Console.WriteLine(vr6);
        return 6155675144223436788L;
    }
}
