using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    public class VehiculoDescuento : Vehiculo
    {
        public double Descuento { get; set; }

        public VehiculoDescuento(string modelo, double precioPorDia, double descuento)
            : base(modelo, precioPorDia)
        {
            Descuento = descuento;
        }

        public double AplicarDescuento()
        {
            if (Descuento > 0)
            {
                return PrecioPorDia * (1 - Descuento / 100);
            }
            return PrecioPorDia;
        }

        public override string MostrarInformacion()
        {
            double precioConDescuento = AplicarDescuento();
            return $"Modelo: {Modelo}, Precio original: ${PrecioPorDia:F2}, Precio con descuento: ${precioConDescuento:F2}";
        }
    }

}
