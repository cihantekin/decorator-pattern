namespace decorator_pattern.Component
{
    public abstract class Scanner
    {
        public string FrontImage { get; set; } = string.Empty;
        public string BackImage { get; set; } = string.Empty;
        public string FaceImageChip { get; set; } = string.Empty;
        public string FaceImageViz { get; set; } = string.Empty;
        public abstract Scanner GetDocumentInformation();
    }
}
