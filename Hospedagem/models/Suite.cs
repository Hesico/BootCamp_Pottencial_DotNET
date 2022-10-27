using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.models
{
    public class Suite
    {
        public Suite(string suiteType, int capacity, decimal dailyPrice){
            this.SuiteType = suiteType;
            this.Capacity = capacity;
            this.DailyPrice = dailyPrice;
        }

        public string SuiteType { get; set; }
        public int Capacity { get; set; }
        public decimal DailyPrice { get; set; }
    }
}