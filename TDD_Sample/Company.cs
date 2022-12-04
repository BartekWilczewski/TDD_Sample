using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Sample
{
    public class Company
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public int Value { get; set; }

        public int CalculateTotal()
        {
            return Value * Amount;
        }
    }
}
