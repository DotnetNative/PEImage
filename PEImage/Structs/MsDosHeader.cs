namespace PEImage.Structs;
public unsafe struct MsDosHeader
{
    public ushort Magic;
    public ushort Cblp;
    public ushort Cp;
    public ushort Crlc;
    public ushort Cparhdr;
    public ushort MinAlloc;
    public ushort MaxAlloc;
    public ushort Ss;
    public ushort Sp;
    public ushort CSum;
    public ushort Ip;
    public ushort Cs;
    public ushort Lfarlc;
    public ushort Ovno;
    public fixed ushort Res[4];
    public ushort OemID;
    public ushort OemInfo;
    public fixed ushort Res2[10];
    public int Lfnew;
}