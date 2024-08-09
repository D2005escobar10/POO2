using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    public class Motocicleta : vehiculo
    {
        private string _tipodemoto;

        public string tipodemoto { get { return _tipodemoto; } set { _tipodemoto = value; } }

        public Motocicleta(string marca, string modelo, int año, int kilometraje, string tipodemoto)
            : base(marca, modelo, año, kilometraje)
        {
            _tipodemoto = tipodemoto;
        }

        public override void Encender()
        {
            Console.WriteLine("Encendiendo Motocicleta");
        }

        public override void Apagar()
        {
            Console.WriteLine("Apagando Motocicleta");
        }

        public override void Conducir(int km)
        {
            Console.WriteLine($"conduciendo Motocicleta {km} km");
            Kilometraje += km;
        }
    }
}
