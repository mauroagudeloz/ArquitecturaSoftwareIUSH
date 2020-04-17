using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseñoSoftwareObserver.Sujeto
{
    //El modificador abstract indica que lo que se modifica carece de implementación o tiene una implementación incompleta.
    public abstract class Observador
    {
        protected SujetoObservado SujetObservado; 
        public abstract void Actualizar();
    }
}
