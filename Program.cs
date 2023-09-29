using Desafio_Celular.Models;

Smartphone nokia = new Nokia("998765432", "C52", "4564C", 800);
Console.WriteLine("\n");
Console.WriteLine("Teste Celular Nokia:");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Smartphone iphone = new Iphone("991234567", "4S", "BBC", 1000);
Console.WriteLine("Teste Celular Iphone:");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("ICQ");
