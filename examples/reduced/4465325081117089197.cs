// Generated by Fuzzlyn on 2018-06-26 03:54:28
// Seed: 4465325081117089197
// Reduced from 33.6 KiB to 0.4 KiB
// Debug: Outputs True
// Release: Outputs False
public class Program
{
    static ulong[] s_2 = new ulong[]{7990196822052590529UL};
    static short[] s_4 = new short[]{0};
    static sbyte[, ] s_5 = new sbyte[, ]{{0}};
    public static void Main()
    {
        s_5[0, 0] = (sbyte)s_2[0];
        bool vr25 = 0 == (s_5[0, 0] / (char)(s_4[0] | s_5[0, 0]));
        System.Console.WriteLine(vr25);
    }
}
