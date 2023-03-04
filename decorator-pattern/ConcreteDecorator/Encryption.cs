using decorator_pattern.Component;
using decorator_pattern.Decorator;
using decorator_pattern.Extensions;

namespace decorator_pattern.ConcreteDecorator
{
    public class Encryption : ScannerDecorator
    {
        // example purposes. read this from environment variables
        private const string EncKey = "b14ca5898a4e4133bbce2ea2315a1916";
        public Encryption(Scanner scanner) : base(scanner)
        {
        }

        public override Scanner GetDocumentInformation()
        {
            var scannerInfo = base.GetDocumentInformation();

            EncryptStringFields(scannerInfo);

            return scannerInfo;
        }

        private static void EncryptStringFields(Scanner scannerInfo)
        {
            scannerInfo.FaceImageChip = scannerInfo.FaceImageChip.EncryptStringContent(EncKey);
            scannerInfo.FaceImageViz = scannerInfo.FaceImageViz.EncryptStringContent(EncKey);
            scannerInfo.FrontImage = scannerInfo.FrontImage.EncryptStringContent(EncKey);
            scannerInfo.BackImage = scannerInfo.BackImage.EncryptStringContent(EncKey);
        }
    }
}
