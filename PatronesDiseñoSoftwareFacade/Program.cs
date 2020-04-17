using PatronesDiseñoSoftwareFacade.Facade;
using System;

namespace PatronesDiseñoSoftwareFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================");
            Console.WriteLine("BUSCAR QUE VEHICULOS ESTÁN EN PROMOCIÓN: ");

            VehiculosPromocion BusquedaCarros = new VehiculosPromocion();
            BusquedaCarros.buscarVehiculosEnPromocion();

            Console.ReadLine();
        }
    }
}
