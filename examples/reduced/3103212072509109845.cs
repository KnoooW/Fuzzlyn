// Generated by Fuzzlyn on 2018-06-03 23:40:45
// Seed: 3103212072509109845
// Reduced from 43.3 KB to 0.3 KB
// Debug: Prints 1 line(s)
// Release: Prints 0 line(s)
public class Program
{
    static sbyte s_1 = 1;
    public static void Main()
    {
        s_1 = -2;
        bool vr44 = (byte)(0L ^ s_1) < 4294967294U;
        if (vr44)
        {
            char vr45 = 'x';
            System.Console.WriteLine((int)vr45);
        }
        else
        {
        }
    }
}
