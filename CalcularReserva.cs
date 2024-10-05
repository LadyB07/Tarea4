using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    public class CalcularReserva
    {
        public Vehiculo Vehiculo { get; set; }
        public int Dias { get; set; }

        public CalcularReserva(Vehiculo vehiculo, int dias)
        {
            Vehiculo = vehiculo;
            Dias = dias;
        }

        public double CalcularCostoTotal()
        {
            return Vehiculo.PrecioPorDia * Dias;
        }

        public double CalcularCostoTotalConDescuento()
        {
            if (Vehiculo is VehiculoDescuento vehiculoDescuento)
            {
                return vehiculoDescuento.AplicarDescuento() * Dias;
            }
            return Vehiculo.PrecioPorDia * Dias;
        }
    }

}
