// Generated by Fuzzlyn on 2018-06-03 23:33:29
// Seed: 2338817277594888886
// Reduced from 5.8 KB to 0.4 KB
// Debug: Prints 1 line(s)
// Release: Prints 0 line(s)
public class Program
{
    static sbyte[, ] s_1 = new sbyte[, ]{{-20}};
    public static void Main()
    {
        bool vr6 = 36 > (byte)(1U ^ s_1[0, 0]);
        if (vr6)
        {
        }
        else
        {
            M1(1);
        }
    }

    static bool M1(ushort arg0)
    {
        System.Console.WriteLine(arg0);
        return false;
    }
}
