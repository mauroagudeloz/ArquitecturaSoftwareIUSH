using System;
using System.Collections.Generic;
using System.Text;
using PatronesDiseñoSoftwareFacade.API;

namespace PatronesDiseñoSoftwareFacade.Facade
{
    class VehiculosPromocion
    {
        private VehiculosMazda MazdaAPI;
        private VehiculosMercedes MercedesAPI;
        private VehiculosChevrolet ChevroletAPI;
        private VehiculoBWM BMWAPI;

        //Constructor.
        public VehiculosPromocion()
        {
            MazdaAPI = new VehiculosMazda();
            MercedesAPI = new VehiculosMercedes();
            ChevroletAPI = new VehiculosChevrolet();
            BMWAPI = new VehiculoBWM();
        }

        //Función buscar. 
        public void buscarVehiculosEnPromocion()
        {
            MazdaAPI.VehiculosEnPromo();
            MercedesAPI.VehiculosEnPromo();
            ChevroletAPI.VehiculosEnPromo();
            BMWAPI.VehiculosEnPromo();
        }
    }
}
