using PatronesDiseñoSoftwareObserver.Sujeto;
using PatronesDiseñoSoftwareObserver.Suscritos;
using System;
using System.Data;

namespace PatronesDiseñoSoftwareObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            SujetoObservado ConvertirTasaCambio = new SujetoObservado();

            new DolarAmericano(ConvertirTasaCambio);
            new DolarAustraliano(ConvertirTasaCambio);
            new PesoMX(ConvertirTasaCambio);


            Console.WriteLine("===============================");
            Console.WriteLine("Para finalizar ingrese el número 0");

            bool runWhile = true;
            do
            {
                Console.WriteLine("===============================");
                Console.WriteLine("Ingresa el valor en pesos colombianos que desea convertir: ");

                int valorIngresado = Convert.ToInt32(Console.ReadLine());

                if (valorIngresado != 0)
                    ConvertirTasaCambio.SetEstado(valorIngresado);
                else
                    runWhile = false;

            } while (runWhile);

            Console.ReadLine();
        }
    }
}
