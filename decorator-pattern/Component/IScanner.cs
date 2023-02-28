namespace decorator_pattern.Component
{
    public interface IScanner
    {
        string FrontImage { get; set; }
        string BackImage { get; set; }
        string FaceImageChip { get; set; }
        string FaceImageViz { get; set; }
        IScanner GetDocumentInformation();
    }
}
