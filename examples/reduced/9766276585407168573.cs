// Generated by Fuzzlyn on 2018-07-25 06:36:28
// Seed: 9766276585407168573
// Reduced from 155.3 KiB to 0.2 KiB
// Debug: Outputs 65450
// Release: Outputs -86
public class Program
{
    static sbyte s_4 = -86;
    public static void Main()
    {
        uint vr16 = default(uint);
        char vr17 = (char)(vr16 ^ s_4);
        System.Console.WriteLine((int)vr17);
    }
}
