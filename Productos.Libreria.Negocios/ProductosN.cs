using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Productos.Libreria.Datos; 
namespace Productos.Libreria.Negocios
{
    public class ProductosN
    {
        ProductosDao objDao = new ProductosDao();
        public DataTable Listar_Categorias()
        {
            return objDao.Listar_Categorias(); 
        }

        public DataTable Productos_Categoria(int id)
        {

            return objDao.Productos_Categoria(id); 
        }

      public  void actualiza_stock(int id, int stock)
        {
            objDao.actualiza_stock(id, stock);
          
        }

    }
}
