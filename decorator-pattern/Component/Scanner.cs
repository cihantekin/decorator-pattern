namespace decorator_pattern.Component
{
    public abstract class Scanner
    {
        public string FrontImage { get; set; }
        public string BackImage { get; set; }
        public string FaceImageChip { get; set; }
        public string FaceImageViz { get; set; }
        public abstract Scanner GetDocumentInformation();
    }
}
