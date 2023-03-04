using decorator_pattern.Component;

namespace decorator_pattern.ConcreteComponent
{
    public class Desko : Scanner
    {
        public Desko(string frontImage, string backImage, string faceImageChip, string faceImageViz)
        {
            FrontImage = frontImage;
            BackImage = backImage;
            FaceImageChip = faceImageChip;
            FaceImageViz = faceImageViz;
        }

        public override Scanner GetDocumentInformation()
        {
            return this;
        }
    }
}
