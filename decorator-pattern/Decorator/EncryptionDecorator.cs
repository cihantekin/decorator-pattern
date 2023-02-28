using decorator_pattern.Component;

namespace decorator_pattern.Decorator
{
    public abstract class EncryptionDecorator : IScanner
    {
        protected IScanner scanner;

        protected EncryptionDecorator(IScanner scanner)
        {
            this.scanner = scanner;
        }

        public virtual IScanner GetDocumentInformation()
        {
            return scanner.GetDocumentInformation();
        }
    }
}
