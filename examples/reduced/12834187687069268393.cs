// Generated by Fuzzlyn on 2018-06-03 22:33:58
// Seed: 12834187687069268393
// Reduced from 84.6 KB to 0.4 KB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C1
{
    public bool F2;
    public long F3;
    public C1()
    {
    }
}

public class Program
{
    static C1[, ] s_9 = new C1[, ]{{new C1()}};
    static char s_16 = 'f';
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        int var0 = -127 * (int)((0L & s_16) * s_9[0, 0].F3);
        bool vr37 = s_9[0, 0].F2;
        System.Console.WriteLine(var0);
    }
}
