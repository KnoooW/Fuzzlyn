// Generated by Fuzzlyn on 2018-06-24 00:58:44
// Seed: 5005097897939219560
// Reduced from 3.1 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
struct S1
{
    public short F1;
}

public class Program
{
    static byte[][, ] s_1 = new byte[][, ]{new byte[, ]{{0}}};
    public static void Main()
    {
        S1 vr3 = default(S1);
        short vr4 = vr3.F1;
        bool vr5 = (0 % ((7977867370378584778L - (vr4 * s_1[0][0, 0])) - s_1[0][0, 0])) > 0;
    }
}
