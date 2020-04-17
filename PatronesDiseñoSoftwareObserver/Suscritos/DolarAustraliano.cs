using PatronesDiseñoSoftwareObserver.Sujeto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseñoSoftwareObserver.Suscritos
{
    class DolarAustraliano : Observador
    {
        private double TasaDeCambio = 2400;
        public DolarAustraliano(SujetoObservado SujetObservado)
        {
            this.SujetObservado = SujetObservado;
            this.SujetObservado.Agregar(this);
        }

        //override - Sobreescribe el método actualizar de la clase abstracta. 
        public override void Actualizar()
        {
            Console.WriteLine("AUD: " + (SujetObservado.GetEstado() / TasaDeCambio));
        }
 
    }
}
