using Estacionamento.models;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
Console.WriteLine("Digite o Preço Inicial:");
decimal initialPrice = Decimal.Parse(Console.ReadLine());
Console.WriteLine("Digite o Preço Por Hora:");
decimal pricePerHour = Decimal.Parse(Console.ReadLine());

Parking parking = new Parking(initialPrice,pricePerHour);

int option = 0;
string plate = "";

while (option != 4)
{
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Remover Veículo");
    Console.WriteLine("3 - Listar Veículos");
    Console.WriteLine("4 - Encerrar");
    option = Int16.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            plate = Convert.ToString(Console.ReadLine());
            parking.AddVehicle(plate);
        break;
        case 2:
            Console.WriteLine("Digite a placa do veículo para remover:");
            plate = Convert.ToString(Console.ReadLine());
            parking.RemoveVehicle(plate);
        break;
        case 3:
            Console.WriteLine("Os Veículos estacionados são:");
            parking.ListVehicles();
        break;
        case 4:
        break;
        default:
            Console.WriteLine("Opção Incorreta. Digite novamente!");
        break;
        
    }
    Console.WriteLine("Precione uma tecla para continuar!");
    Console.ReadLine();
    Console.Clear();
}
Console.WriteLine("O programa se encerrou!");