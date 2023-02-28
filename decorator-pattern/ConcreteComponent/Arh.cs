using decorator_pattern.Component;

namespace decorator_pattern.ConcreteComponent
{
    public class Arh : Scanner
    {
        public Arh(string frontImage, string backImage, string faceImageChip, string faceImageViz)
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
