// Generated by Fuzzlyn on 2018-07-27 05:21:59
// Seed: 14416504607206894409
// Reduced from 85.8 KiB to 0.3 KiB
// Debug: Outputs 360652544
// Release: Outputs 0
public class Program
{
    static sbyte s_1 = 127;
    public static void Main()
    {
        short vr38 = s_1++;
        var vr34 = 14671344379231149920UL & (uint)M11();
        System.Console.WriteLine(vr34);
    }

    static sbyte M11()
    {
        return s_1;
    }
}
