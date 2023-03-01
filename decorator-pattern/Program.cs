// See https://aka.ms/new-console-template for more information
using decorator_pattern.ConcreteComponent;
using decorator_pattern.ConcreteDecorator;

Console.WriteLine("Hello, World!");
var arhScanner = new Arh("frontimagebase64", "backimagebase64", "faceimagechipbase64", "faceimagevizbase64");
var encDecorator = new Encryption(arhScanner).GetDocumentInformation();

Console.WriteLine(encDecorator.FaceImageChip.ToString());