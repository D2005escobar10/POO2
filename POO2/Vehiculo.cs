using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    public abstract class vehiculo
    {
        private string _marca;
        private string _modelo;
        private int _año;
        private int _kilometraje;

        public string Marca { get { return _marca; } set { _marca = value; } }
        public string Modelo { get { return _modelo; } set { _modelo = value; } }
        public int Año { get { return _año; } set { _año = value; } }
        public int Kilometraje { get { return _kilometraje; } set { _kilometraje = value; } }

        public abstract void Encender();
        public abstract void Apagar();
        public abstract void Conducir(int km);

        public vehiculo(string marca, string modelo, int año, int kilometraje)
        {
            _marca = marca;
            _modelo = modelo;
            _año = año;
            _kilometraje = kilometraje;
        }
    }
}
