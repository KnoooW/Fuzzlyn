// Generated by Fuzzlyn on 2018-06-21 13:46:54
// Seed: 11672472875164723842
// Reduced from 55.1 KiB to 0.3 KiB
// Debug: Prints 0 line(s)
// Release: Prints 1 line(s)
public class Program
{
    static ulong s_1;
    public static void Main()
    {
        sbyte[] vr6 = new sbyte[]{-10};
        bool vr7 = (byte)(0U ^ vr6[0]) < 0;
        if (vr7)
        {
            System.Console.WriteLine(s_1);
        }
    }
}
