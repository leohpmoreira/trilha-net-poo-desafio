using DesafioPOO.Models;

Console.WriteLine("iPhone:");
var iphoneTest = new Iphone("91234-5678", "iPhone 16 Pro Max", "213553049572979", 16);
iphoneTest.Ligar();
iphoneTest.ReceberLigacao();
iphoneTest.InstalarAplicativo("YouTube");

Console.WriteLine("\nNokia:");
var nokiaTest = new Nokia("99876-5432", "Nokia 3310", "306877799098181", 32);
nokiaTest.Ligar();
nokiaTest.ReceberLigacao();
nokiaTest.InstalarAplicativo("Facebook");