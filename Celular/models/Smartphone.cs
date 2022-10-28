using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular.models
{
    public abstract class Smartphone
    {
        public Smartphone(string number, string model, string iMEI, int memory){
            this.Number = number;
            this.Model = model;
            this.IMEI = iMEI;
            this.Memory = memory;
            
        }

        public string Number { get; set; }
        protected string Model;
        protected string IMEI;
        protected int Memory;

        public void Call(string number){
            Console.WriteLine("Ligando para: " +  number);
        }

        public void ReceiveCall(string number){
            Console.WriteLine("Recebendo ligação de " + number);
        }

        public abstract void InstallApp(string appName);
    }
}