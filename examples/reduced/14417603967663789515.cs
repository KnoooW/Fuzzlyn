// Generated by Fuzzlyn on 2018-06-03 22:47:11
// Seed: 14417603967663789515
// Reduced from 253.1 KB to 0.4 KB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static ushort[, ] s_1 = new ushort[, ]{{52167}};
    public static void Main()
    {
        var vr227 = (sbyte)((0 & s_1[0, 0]) - s_1[0, 0]);
        var vr228 = new ushort[]{11180};
        M2(vr227, 1, vr228);
    }

    static byte M2(sbyte arg1, byte arg2, ushort[] arg4)
    {
        System.Console.WriteLine(arg4[0]);
        return arg2;
    }
}
