// Generated by Fuzzlyn on 2018-06-04 00:37:08
// Seed: 8300596973709088850
// Reduced from 179.7 KB to 0.9 KB
// Debug: Outputs 65529
// Release: Outputs 4294967289
struct S0
{
    public char F0;
    public short F1;
    public uint F2;
    public long F3;
    public bool F4;
    public sbyte F5;
    public S0(char f0, short f1, uint f2, long f3, bool f4, sbyte f5)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
        F5 = f5;
    }
}

public class Program
{
    static S0 s_1 = new S0('X', -1779, 1U, -5727238492868077887L, true, -24);
    static S0[] s_14 = new S0[]{new S0(')', -26309, 3623547137U, 7268526994553380095L, false, 34)};
    static S0 s_18 = new S0('y', 23636, 4294967294U, 0L, true, -20);
    static uint s_37 = 570227686U;
    public static void Main()
    {
        s_14[0] = s_1;
        char vr179 = M76();
        s_37 = vr179;
        System.Console.WriteLine(s_37);
    }

    static char M76()
    {
        return (char)(s_18.F0 | s_14[0].F5);
    }
}
