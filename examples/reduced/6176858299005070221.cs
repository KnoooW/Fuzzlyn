// Generated by Fuzzlyn on 2018-07-03 06:25:01
// Seed: 6176858299005070221
// Reduced from 10.5 KiB to 0.3 KiB
// Debug: Outputs 65482
// Release: Outputs -54
struct S0
{
    public sbyte F0;
    public S0(sbyte f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    public static void Main()
    {
        var vr4 = new S0[]{new S0(-53)};
        int vr9 = (char)(vr4[0].F0 ^ 1U);
        System.Console.WriteLine(vr9);
    }
}
