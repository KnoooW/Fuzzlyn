// Generated by Fuzzlyn on 2018-06-03 23:00:52
// Seed: 15652638411539516545
// Reduced from 1.5 KB to 0.5 KB
// Debug: Outputs 223
// Release: Outputs 58847
struct S0
{
    public uint F0;
    public uint F1;
    public sbyte F2;
    public char F3;
    public uint F4;
    public S0(uint f0, uint f1, sbyte f2, char f3, uint f4)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
    }
}

public class Program
{
    public static void Main()
    {
        S0 vr0 = new S0(855172573U, 0U, 2, 'L', 1367152188U);
        vr0.F3 = (char)(vr0.F2 + (byte)vr0.F0);
        System.Console.WriteLine((int)vr0.F3);
    }
}
