// Generated by Fuzzlyn on 2018-06-03 22:08:42
// Seed: 10914986940509833665
// Reduced from 16.7 KB to 0.4 KB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static sbyte[, ] s_5 = new sbyte[, ]{{126}};
    public static void Main()
    {
        byte vr38 = (byte)(0UL & (ulong)s_5[0, 0]);
        var vr39 = s_5[0, 0] == vr38;
        var vr40 = new byte[]{255};
        M12(vr39, vr40);
    }

    static sbyte M12(bool arg0, byte[] arg1)
    {
        System.Console.WriteLine(arg1[0]);
        return 1;
    }
}
