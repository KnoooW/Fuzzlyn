// Generated by Fuzzlyn on 2018-07-01 13:11:12
// Seed: 16054864535118919137
// Reduced from 40.0 KiB to 0.3 KiB
// Debug: Outputs 32769
// Release: Outputs 4294934529
public class Program
{
    static short[][, ] s_2 = new short[][, ]{new short[, ]{{-32767}}};
    static long s_3;
    public static void Main()
    {
        var vr5 = (char)(s_3 ^ s_2[0][0, 0]);
        uint vr9 = vr5;
        System.Console.WriteLine(vr9);
    }
}
