// Generated by Fuzzlyn on 2018-06-04 00:10:04
// Seed: 6034399194913324734
// Reduced from 5.3 KB to 0.3 KB
// Debug: Outputs 65535
// Release: Outputs 4294967295
public class Program
{
    static sbyte s_2 = 44;
    public static void Main()
    {
        s_2 = -1;
        uint vr16 = (uint)('J' | s_2);
        char vr17 = (char)vr16;
        long vr7 = vr17;
        System.Console.WriteLine(vr7);
    }
}
