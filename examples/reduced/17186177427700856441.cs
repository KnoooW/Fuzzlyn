// Generated by Fuzzlyn on 2018-06-03 23:15:46
// Seed: 17186177427700856441
// Reduced from 98.5 KB to 0.9 KB
// Debug: Outputs 32779
// Release: Outputs 4294934539
class C0
{
    public short F3;
    public C0(short f3)
    {
        F3 = f3;
    }
}

struct S1
{
    public C0 F0;
    public byte F1;
    public char F2;
    public sbyte F3;
    public char F4;
    public ulong F5;
    public short F6;
    public sbyte F7;
    public C0 F8;
    public S1(C0 f0, byte f1, char f2, sbyte f3, char f4, ulong f5, short f6, sbyte f7, C0 f8)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
        F5 = f5;
        F6 = f6;
        F7 = f7;
        F8 = f8;
    }
}

public class Program
{
    static S1[] s_2 = new S1[]{new S1(new C0(21264), 0, 'C', -124, 'X', 1812620582143254778UL, 1824, -105, new C0(32767))};
    static C0 s_3 = new C0(-32767);
    public static void Main()
    {
        s_2[0].F0 = s_3;
        char vr76 = (char)(10L | s_2[0].F0.F3);
        uint vr77 = vr76;
        System.Console.WriteLine(vr77);
    }
}
