using decorator_pattern.Component;

namespace decorator_pattern.ConcreteComponent
{
    public class Arh : IScanner
    {
        public string FrontImage { get; set; }
        public string BackImage { get; set; }
        public string FaceImageChip { get; set; }
        public string FaceImageViz { get; set; }

        public Arh(string frontImage, string backImage, string faceImageChip, string faceImageViz)
        {
            FrontImage = frontImage;
            BackImage = backImage;
            FaceImageChip = faceImageChip;
            FaceImageViz = faceImageViz;
        }

        public IScanner GetDocumentInformation()
        {
            return this;
        }
    }
}
