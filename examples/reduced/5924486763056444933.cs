// Generated by Fuzzlyn on 2018-06-04 00:09:20
// Seed: 5924486763056444933
// Reduced from 63.9 KB to 0.3 KB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static short[, ] s_1 = new short[, ]{{1}};
    public static void Main()
    {
        bool vr52 = 3931610861U == (s_1[0, 0] & 0U);
        if (vr52)
        {
        }
        else
        {
            s_1[0, 0] = 1;
        }
    }
}
