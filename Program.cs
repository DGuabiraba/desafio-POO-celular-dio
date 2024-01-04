using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"81-9.9224-2975",modelo:"modelo Nokia 3310",imei:"987865321",memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Orkut");
nokia.ReceberLigacao();

Console.WriteLine("\n");
Console.WriteLine("smartphone iPhone: ");
Smartphone iphone = new Iphone(numero:"81-9.9224-2975",modelo:"iPhone 7",imei:"987865321",memoria: 32);
iphone.Ligar();
iphone.InstalarAplicativo("itunes");
iphone.ReceberLigacao();

// TODO: Realizar os testes com as classes Nokia e Iphone