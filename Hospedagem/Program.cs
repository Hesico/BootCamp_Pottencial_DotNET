using Hospedagem.models;

// Criação de Pessoas
Person henrique = new Person("Henrique","Coutinho");
Person pedro = new Person("Pedro","Pedra");
Person andre = new Person("Andre","Silva");
Person paulo = new Person("Paulo","Oliveira");

Suite firstSuite = new Suite("Simple",3,50.00M);
Suite secondSuite = new Suite("Premium",4,250.00M);

Reservation vocationSep = new Reservation(5);
Reservation vocationDec = new Reservation(10);

vocationSep.RegisterSuite(firstSuite);
vocationDec.RegisterSuite(secondSuite);

vocationSep.RegisterGuests(henrique);
vocationSep.RegisterGuests(pedro);
vocationSep.RegisterGuests(andre);

//Esperado o retorno da mensagem de Erro
vocationSep.RegisterGuests(paulo);

vocationDec.RegisterGuests(henrique);
vocationDec.RegisterGuests(pedro);
vocationDec.RegisterGuests(andre);
vocationDec.RegisterGuests(paulo);

// Esperado: 3, 250.00
Console.WriteLine($"Número de Hospedes: {vocationSep.GetGuestsCount()}");
Console.WriteLine($"Preço total: R$ {vocationSep.CalculatePrice()}");

Console.WriteLine("---------------");

//Esperado: 4, 2250,00
Console.WriteLine($"Número de Hospedes: {vocationDec.GetGuestsCount()}");
Console.WriteLine($"Preço total: R$ {vocationDec.CalculatePrice()}");
