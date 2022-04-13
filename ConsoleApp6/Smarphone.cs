using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Smarphone
    {
        
        public string Name { get;  set; }
        public string Color { get; set; }
        public int Battery { get; set; }
        public int Camera { get; set; }
        public Smarphone()
        {
            this.Name = String.Empty;
            this.Color = String.Empty;
            this.Battery = Battery;
            this.Camera = Camera;
        }
        public Smarphone(string name, string color,int battery,int camera)
        {
            Name = name;
            Color = color;
            Battery = battery;
            Camera = camera;
        }
        public void PhoneOn() => Console.WriteLine("Работает отлично");
        public override string ToString()
        {
            return $"Name: {Name}\nColor: {Color}\nBattery: {Battery}\nCamera: {Camera}\n";
        }
    }
}
