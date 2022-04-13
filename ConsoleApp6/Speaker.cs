using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Speaker
    {
        public string PhoneSpeak { get; set; }
      
        public Speaker()
        {
            this.PhoneSpeak = String.Empty;
          
        }
        public Speaker(string phonespeak)
        {
            PhoneSpeak = phonespeak;
           
        }
   
        public override string ToString()
        {
            return $"Телефон: {PhoneSpeak}";
        }
    }
}
