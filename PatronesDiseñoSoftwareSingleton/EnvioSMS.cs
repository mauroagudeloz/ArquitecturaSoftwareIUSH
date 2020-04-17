using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseñoSoftwareSingleton
{


    public class EnvioSMS
    {
        private static EnvioSMS EnviarSMSInstance = null;
        private EnvioSMS()
        {

        }

        public static EnvioSMS GetInstance
        {
            get
            {
                if (EnviarSMSInstance == null)
                    EnviarSMSInstance = new EnvioSMS();

                return EnviarSMSInstance;
            }
        }

        public bool EnviarSMS(string Mensaje)
        {
            try
            {
                Console.WriteLine(Mensaje);

                return true;
            }
            catch (Exception) { return false; }
        }

    }





    //Multithreaded Singleton
    public sealed class Singleton
    {
        private static volatile Singleton instance;
        private static object syncRoot = new Object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }

                return instance;
            }
        }
    }


}
