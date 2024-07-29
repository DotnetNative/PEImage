namespace PEImage.Structs;
public unsafe struct PEImage
{
    public MsDosHeader MsDosHeader;
    public fixed byte Signature[4];
    public ImageFileHeader FileHeader;
    public ImageOptionalHeader OptionalHeader;
    public ImageSectionHeader[] SectionHeader;
}