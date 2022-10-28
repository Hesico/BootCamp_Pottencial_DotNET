using Celular.models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("(32) 99999-8888", "Pro", "1111", 256);
nokia.Call("(32) 91111-2222");
nokia.ReceiveCall("(32) 92222-3333");
nokia.InstallApp("WhatsApp");

Console.WriteLine("_________________");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone("(32) 98888-7777", "Pro Max", "2222", 128);
iphone.Call("(32) 92222-2222");
iphone.ReceiveCall("(32) 93333-3333");
iphone.InstallApp("Telegram");

