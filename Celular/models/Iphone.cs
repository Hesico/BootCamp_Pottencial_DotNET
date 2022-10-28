using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular.models
{
    public class Iphone : Smartphone
    {
        public Iphone(string number, string model, string iMEI, int memory) : base(number, model, iMEI, memory){

        }

        public override void InstallApp(string appName)
        {
            Console.WriteLine($"App {appName} instalado no Iphone com Sucesso!!");
        }
    }
}