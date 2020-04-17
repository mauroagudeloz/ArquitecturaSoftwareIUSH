using PatronesDiseñoSoftwareObserver.Sujeto;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseñoSoftwareObserver.Suscritos
{
    public class DolarAmericano : Observador
    {
        private double TasaDeCambio = 3900; 
        public DolarAmericano(SujetoObservado SujetObservado)
        {
            this.SujetObservado = SujetObservado;
            this.SujetObservado.Agregar(this);
        }

        //override - Sobreescribe el método actualizar de la clase abstracta. 
        public override void Actualizar()
        {
            Console.WriteLine("US: " + (SujetObservado.GetEstado()/TasaDeCambio));
        }
    }
}
