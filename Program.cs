using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "999991234", modelo: "15", imei: "123456789", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "988881234", modelo: "3310", imei: "987654321", memoria: 8);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");
