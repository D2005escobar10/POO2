using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    public class Camion : vehiculo
    {
        private int _capacidaddecarga;

        public int Capacidaddecarga { get { return _capacidaddecarga; } set { _capacidaddecarga = value; } }

        public Camion(string marca, string modelo, int año, int kilometraje, int capacidaddecarga)
            : base(marca, modelo, año, kilometraje)
        {
            _capacidaddecarga = capacidaddecarga;
        }

        public override void Encender()
        {
            Console.WriteLine("Encendiendo Camion");
        }

        public override void Apagar()
        {
            Console.WriteLine("Apagando Camion");
        }

        public override void Conducir(int km)
        {
            Console.WriteLine($"conduciendo Camion {km} km");
            Kilometraje += km;
        }
    }
}
