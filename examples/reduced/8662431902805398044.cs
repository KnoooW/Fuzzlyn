// Generated by Fuzzlyn on 2018-06-04 01:00:30
// Seed: 8662431902805398044
// Reduced from 104.9 KB to 0.3 KB
// Debug: Outputs 65535
// Release: Outputs -1
public class Program
{
    static short s_1 = 32505;
    public static void Main()
    {
        s_1 ^= s_1;
        ushort vr184 = (ushort)s_1--;
        char vr185 = (char)(s_1 ^ 0U);
        int vr186 = vr185;
        System.Console.WriteLine(vr186);
    }
}
