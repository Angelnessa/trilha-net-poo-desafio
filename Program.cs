using DesafioPOO.Models;


Console.WriteLine($"Smartphone Nokia:");
Smartphone Nokia = new Nokia("24531557" , "C01 Plus" , "148647" , 64);

Nokia.Ligar();
Nokia.InstalarAplicativo("Facebook");


Console.WriteLine($"Smartphone Iphone:");
Smartphone Iphone = new Iphone("54972301" , "Plus geração 14" , "245930" , 128);


Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Instagram");
