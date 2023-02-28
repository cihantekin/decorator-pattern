using decorator_pattern.Component;

namespace decorator_pattern.Decorator
{
    public abstract class ScannerDecorator : Scanner
    {
        protected Scanner scanner;

        protected ScannerDecorator(Scanner scanner)
        {
            this.scanner = scanner;
        }

        public override Scanner GetDocumentInformation()
        {
            return scanner.GetDocumentInformation();
        }
    }
}
