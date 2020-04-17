using System;
using System.ComponentModel.Design.Serialization;

namespace PatronesDiseñoSoftwareSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            EnvioSMS NombreVariable = EnvioSMS.GetInstance;
            NombreVariable.EnviarSMS("Mauro, Escribir mensaje 1 en consola");

            EnvioSMS NombreVariable2 = EnvioSMS.GetInstance;
            NombreVariable2.EnviarSMS("Mauro, Escribir mensaje 2 en consola");

            EnvioSMS NombreVariable3 = EnvioSMS.GetInstance;
            NombreVariable3.EnviarSMS("Mauro, Escribir mensaje 3 en consola");

            EnvioSMS NombreVariable4 = EnvioSMS.GetInstance;
            NombreVariable4.EnviarSMS("Mauro, Escribir mensaje 4 en consola");


            
            Console.ReadLine();
        }


    }
}
