// Generated by Fuzzlyn v1.1 on 2018-08-26 04:17:16
// Seed: 747566651241064624
// Reduced from 12.1 KiB to 0.2 KiB
// Debug: Outputs 4294967260
// Release: Outputs 220
public class Program
{
    static sbyte s_3 = -36;
    public static void Main()
    {
        ref sbyte vr4 = ref s_3;
        long vr3 = vr4;
        uint vr0 = (uint)(ulong)(uint)vr3;
        System.Console.WriteLine(vr0);
    }
}
