// Generated by Fuzzlyn on 2018-06-04 00:55:47
// Seed: 8530816436067432159
// Reduced from 45.5 KB to 0.3 KB
// Debug: Outputs 65443
// Release: Outputs 4294967203
public class Program
{
    static sbyte s_3 = -35;
    public static void Main()
    {
        char vr71 = M9();
        ulong vr69 = vr71;
        System.Console.WriteLine(vr69);
    }

    static char M9()
    {
        return (char)(s_3 ^ 126);
    }
}
