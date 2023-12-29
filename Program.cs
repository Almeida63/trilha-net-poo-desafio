using DesafioPOO.Models;

Console.WriteLine("Iphone");
Smartphone iphone1 = new Iphone("933241", "Iphone X", "2323", 64);
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Nokia");
Smartphone nokia1 = new Nokia("932123", "Nokia Lumia 930", "4321", 32);
nokia1.Ligar();
nokia1.InstalarAplicativo("Facebook");