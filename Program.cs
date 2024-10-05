using System;
namespace Tarea4 {
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un vehículo sin descuento
            Vehiculo vehiculoNormal = new Vehiculo("Toyota Corolla", 100);
            Console.WriteLine(vehiculoNormal.MostrarInformacion());

            // Crear un vehículo con descuento
            VehiculoDescuento vehiculoConDescuento = new VehiculoDescuento("Honda Civic", 120, 10);
            Console.WriteLine(vehiculoConDescuento.MostrarInformacion());

            // Calcular la reserva sin descuento
            CalcularReserva reservaNormal = new CalcularReserva(vehiculoNormal, 5);
            Console.WriteLine($"Costo total sin descuento: ${reservaNormal.CalcularCostoTotal():F2}");

            // Calcular la reserva con descuento
            CalcularReserva reservaConDescuento = new CalcularReserva(vehiculoConDescuento, 5);
            Console.WriteLine($"Costo total con descuento: ${reservaConDescuento.CalcularCostoTotalConDescuento():F2}");
        }
    }
}
