// Generated by Fuzzlyn on 2018-07-09 12:47:01
// Seed: 8224665650207410420
// Reduced from 259.0 KiB to 0.4 KiB
// Debug: Prints 0 line(s)
// Release: Prints 1 line(s)
public class Program
{
    static sbyte s_1;
    public static void Main()
    {
        s_1 = (sbyte)(s_1 - 2291103989935696163L);
        bool vr3 = 0 >= (byte)(0U | s_1);
        if (vr3)
        {
            var vr4 = new long[, ][]{{new long[]{0}}};
            System.Console.WriteLine(vr4[0, 0][0]);
        }
        else
        {
        }
    }
}
