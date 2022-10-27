using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.models
{
    public class Reservation
    {
        public Reservation(int reservedDays){
            this.ReservedDays = reservedDays;
        }

        private List<Person> HotelGuest = new List<Person>();
        private Suite ReservationSuite;
        private int ReservedDays;

        public void RegisterGuests(Person guest){
            try{
                if(ReservationSuite.Capacity - GetGuestsCount() > 0){
                    HotelGuest.Add(guest);
                }else{
                    throw new Exception("Não é possivel adicionar Hospede. Suíte lotada!");
                }
            } catch (Exception e){
                Console.WriteLine(e.Message);
            }
            
        }

        public void RegisterSuite(Suite suite){
            this.ReservationSuite = suite;
        }

        public int GetGuestsCount(){
            return HotelGuest.Count;
        }

        public decimal CalculatePrice(){
            decimal discount = ReservedDays >= 10 ? 0.1M : 0.0M;
            return ReservationSuite.DailyPrice*ReservedDays*(1-discount);
        }
    }
}