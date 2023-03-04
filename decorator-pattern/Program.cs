// See https://aka.ms/new-console-template for more information
using decorator_pattern.ConcreteComponent;
using decorator_pattern.ConcreteDecorator;

Console.WriteLine("Decorator pattern implementation!");

var arhScanner = new Arh("frontimagebase64", "backimagebase64", "faceimagechipbase64", "faceimagevizbase64");
var encDecorator = new Encryption(arhScanner).GetDocumentInformation();

var deskoScanner = new Desko("front", "back", "faceimagechip", "faceimageviz");
var enc = new Encryption(deskoScanner).GetDocumentInformation();

Console.WriteLine(encDecorator.FaceImageChip.ToString());
Console.WriteLine(enc.FrontImage.ToString());