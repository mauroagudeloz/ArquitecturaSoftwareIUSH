using PatronesDiseñoSoftwareObserver.Sujeto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseñoSoftwareObserver.Suscritos
{
    class PesoMX : Observador
    {
        private double TasaDeCambio = 160;
        public PesoMX(SujetoObservado SujetObservado)
        {
            this.SujetObservado = SujetObservado;
            this.SujetObservado.Agregar(this);
        }

        //override - Sobreescribe el método actualizar de la clase abstracta. 
        public override void Actualizar()
        {
            Console.WriteLine("MX: " + (SujetObservado.GetEstado() * TasaDeCambio));
        }

    }
}
