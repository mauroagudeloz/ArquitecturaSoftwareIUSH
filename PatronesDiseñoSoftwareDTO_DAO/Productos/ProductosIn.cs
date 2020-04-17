using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseñoSoftwareDTO_DAO.Productos
{
    //Interface. 
    public abstract class ProductosIn
    {
        public abstract void CrearProducto();
        public abstract void ActualizarProducto();
        public abstract void ConsultarProducto();
        public abstract void EliminarProducto();

    }
}
