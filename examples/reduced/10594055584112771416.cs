// Generated by Fuzzlyn on 2018-06-03 22:04:26
// Seed: 10594055584112771416
// Reduced from 139.4 KB to 0.3 KB
// Debug: Outputs 2
// Release: Outputs 65534
public class Program
{
    static long s_4 = 9223372036854775807L;
    static ushort s_5 = 1;
    public static void Main()
    {
        ++s_5;
        s_5 = (ushort)((char)(sbyte)(127 ^ s_4) % (s_5 | 1));
        System.Console.WriteLine(s_5);
    }
}
