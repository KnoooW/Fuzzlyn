// Generated by Fuzzlyn on 2018-06-03 23:12:54
// Seed: 16818791214103601701
// Reduced from 118.6 KB to 0.2 KB
// Debug: Outputs 255
// Release: Outputs 4294967295
public class Program
{
    static sbyte[, ] s_24 = new sbyte[, ]{{-2}};
    public static void Main()
    {
        byte vr100 = (byte)(1U | s_24[0, 0]);
        uint vr97 = vr100;
        System.Console.WriteLine(vr97);
    }
}
