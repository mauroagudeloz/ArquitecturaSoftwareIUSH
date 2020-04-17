using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseñoSoftwareDTO_DAO.Productos
{
    //DTO Data Transfer Object -> Definición de la estructura de objectos (NO ENTIDAD). 
    public class ProductosDTO
    {

        public class Producto
        {
            public int IdProducto { get; set; }
            public string Nombre { get; set; }
            public int Categoria { get; set; }
        }

        public class ProductoDetalle 
        {
            public int IdDetalleProducto { get; set; }
            public double ValorProducto { get; set; }
            public int Categoria { get; set; }
        }
        

    }
}
