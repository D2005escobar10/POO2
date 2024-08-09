using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    public class Auto : vehiculo
    {
        private int _numerodepuertas;

        public int Numerodepuertas { get { return _numerodepuertas; } set { _numerodepuertas = value; } }

        public Auto(string marca, string modelo, int año, int kilometraje, int numerodepuertas)
            : base(marca, modelo, año, kilometraje)
        {
            _numerodepuertas = numerodepuertas;
        }

        public override void Encender()
        {
            Console.WriteLine("Encendiendo Auto");
        }

        public override void Apagar()
        {
            Console.WriteLine("Apagando Auto");
        }

        public override void Conducir(int km)
        {
            Console.WriteLine($"conduciendo auto {km} km");
            Kilometraje += km;
        }
    }
}

