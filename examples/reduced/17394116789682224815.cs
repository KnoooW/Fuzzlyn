// Generated by Fuzzlyn on 2018-06-03 23:21:34
// Seed: 17394116789682224815
// Reduced from 138.7 KB to 0.2 KB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static byte[][, ] s_1 = new byte[][, ]{new byte[, ]{{207}}};
    public static void Main()
    {
        int vr150 = s_1[0][0, 0] & 0;
        uint vr151 = s_1[0][0, 0];
        System.Console.WriteLine(vr150);
    }
}
