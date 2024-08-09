using System;

namespace POO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("Porsche", "Cayman", 2012, 0, 2);

            Motocicleta motocicleta = new Motocicleta("BMW", "S100RR", 2022, 0, "Deportiva");
            Camion camion = new Camion("Toyota", "Dyna", 2021, 0, 2000);

            Console.WriteLine("Auto");
            auto.Encender();
            auto.Conducir(100);
            auto.Apagar();
            Console.WriteLine(" ");

            Console.WriteLine("Motocicleta");
            motocicleta.Encender();
            motocicleta.Conducir(150);
            motocicleta.Apagar();
            Console.WriteLine(" ");

            Console.WriteLine("Camion");
            camion.Encender();
            camion.Conducir(200);
            camion.Apagar();
        }
    }
}
