using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.models
{
    public class Parking
    {
        public Parking (decimal InitialPrice,decimal PricePerHour){
            this.InitialPrice = InitialPrice;
            this.PricePerHour = PricePerHour;
        }

        public decimal InitialPrice { get; set; }
        public decimal PricePerHour { get; set; }
        public List<string> Vehicles = new List<string>();
        
        public void AddVehicle(string Vehicle){

            if(!Vehicles.Contains(Vehicle)){
                Vehicles.Add(Vehicle);
            }else{
                Console.WriteLine("Veículo já cadastrado!");
            }
            
        }

        public void RemoveVehicle(string Vehicle){
            
            if(!Vehicles.Contains(Vehicle)){
                Console.WriteLine("O veículo não encontrado!");
            }else{
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                decimal totalHour = decimal.Parse(Console.ReadLine());
                decimal totalPrice = totalHour*PricePerHour + InitialPrice;
                Vehicles.Remove(Vehicle);
                Console.WriteLine($"O veículo {Vehicle} foi removido e o preço total foi de R$ {totalPrice}");
            }

        }

        public void ListVehicles(){

            if(Vehicles.Count > 0){
                foreach (var item in Vehicles)
                {
                    Console.WriteLine(item);
                }
            }else{
                Console.WriteLine("Não há veículos!");
            }
        }
    }
}