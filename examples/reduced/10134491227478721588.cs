// Generated by Fuzzlyn v1.1 on 2018-08-05 15:36:56
// Seed: 10134491227478721588
// Reduced from 87.1 KiB to 0.5 KiB
// Debug: Outputs -60
// Release: Outputs 0
struct S0
{
    public sbyte F0;
    public ulong F8;
    public S0(sbyte f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0 s_7;
    static S0[, ] s_25 = new S0[, ]{{new S0(0)}};
    public static void Main()
    {
        M26() = s_25[0, 0];
        var vr6 = s_7.F0;
        System.Console.WriteLine(vr6);
    }

    static ref S0 M26()
    {
        s_25 = new S0[, ]{{new S0(-60)}};
        return ref s_7;
    }
}
