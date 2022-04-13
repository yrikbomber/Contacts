using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Charge
    {
        public string Charg { get; set; }

        public Charge()
        {
            this.Charg = String.Empty;

        }
        public Charge(string charging)
        {
            Charg = charging;

        }

        public override string ToString()
        {
            return $"Системный помощник: {Charg}";
        }







    }
}
