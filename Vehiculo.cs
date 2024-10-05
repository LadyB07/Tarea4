using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    public class Vehiculo
    {
        public string Modelo { get; set; }
        public double PrecioPorDia { get; set; }

        public Vehiculo(string modelo, double precioPorDia)
        {
            Modelo = modelo;
            PrecioPorDia = precioPorDia;
        }

        public virtual string MostrarInformacion()
        {
            return $"Modelo: {Modelo}, Precio por día: ${PrecioPorDia:F2}";
        }
    }

}
