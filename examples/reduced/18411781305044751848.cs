// Generated by Fuzzlyn v1.1 on 2018-08-18 20:57:58
// Seed: 18411781305044751848
// Reduced from 217.2 KiB to 0.2 KiB
// Debug: Outputs 4294967295
// Release: Outputs 65535
public class Program
{
    static short s_2;
    public static void Main()
    {
        var vr31 = s_2--;
        var vr32 = (uint)s_2;
        ulong vr33 = vr32;
        System.Console.WriteLine(vr33);
    }
}
