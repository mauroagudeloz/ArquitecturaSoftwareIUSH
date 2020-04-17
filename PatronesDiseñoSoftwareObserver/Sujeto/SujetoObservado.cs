using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseñoSoftwareObserver.Sujeto
{
    public class SujetoObservado
    {
        private readonly List<Observador> Observadores = new List<Observador>();
        private int estado;

        public int GetEstado()
        {
            return estado;
        }

        public void SetEstado(int estado)
        {
            this.estado = estado;
            NotificarALosObservadores();

        }

        public void Agregar(Observador observador)
        {
            Observadores.Add(observador);
        }

        private void NotificarALosObservadores()
        {
            Observadores.ForEach(Obsr => Obsr.Actualizar());
        }
    }
}
