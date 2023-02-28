using decorator_pattern.Component;
using decorator_pattern.Decorator;

namespace decorator_pattern.ConcreteDecorator
{
    public class Encryption : ScannerDecorator
    {
        public Encryption(Scanner scanner) : base(scanner)
        {
        }

        public override Scanner GetDocumentInformation()
        {
            var scannerInfo = base.GetDocumentInformation();
            
            //implement encryption methods for scannerInfo string fields. Manipulate fields with encrypted values

            return scannerInfo;
        }
    }
}
