using System;
using System.Collections.Generic;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
           
            

            List<Charge> ch = new List<Charge>();
            ch.Add(new Charge("Заряжать не нужно!"));
            ch.ForEach(Console.WriteLine);
            //////////////////////////////////////////////
            List<Camera> camera = new List<Camera>();
            camera.Add(new Camera("image on phone saved good!"));
            camera.ForEach(Console.WriteLine);
            //////////////////////////////////////////////
            List<Speaker> speak = new List<Speaker>();
            speak.Add(new Speaker("Работает"));
            speak.ForEach(Console.WriteLine);
            //////////////////////////////////////////////
           List<Smarphone> smart = new List<Smarphone>();       
            smart.Add(new Smarphone("IPhone X", "Blue", 80,32));
            smart.ForEach(Console.WriteLine);
        }
       
    }
}
