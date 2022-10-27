using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.models
{
    public class Person
    {
        public Person(string name, string lastName){
            this.Name = name;
            this.LastName = lastName;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
    }
}