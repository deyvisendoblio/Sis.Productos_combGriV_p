using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace Productos.Libreria.Datos
{
    public class ProductosDao
    {
        // recuperamos la cadena de conexion
        string cad_cn =ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

       //mérodo para invocar al sp de categorias

        public DataTable Listar_Categorias()
        {
            DataTable tb = new DataTable();
            using (SqlDataAdapter da = 
                 new SqlDataAdapter("USP_LISTAR_CATEGORIAS", cad_cn))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(tb);
            }
            return tb;
        }
        public DataTable Productos_Categoria(int id)
        {
            DataTable tb = new DataTable();
            using (SqlDataAdapter da =
                 new SqlDataAdapter("USP_CONSUTA_PROD_CAT",cad_cn))
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@id", id);
                da.Fill(tb);
            }
            return tb;
        }

        public void actualiza_stock(int id, int stock)
        {
            using (SqlConnection cn = new SqlConnection(cad_cn ))
            {
                SqlCommand cmd = new SqlCommand("USP_ACTUALIZAR_STOCK", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.Add("@stock", SqlDbType.Int).Value = stock;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        //git 1
    }
}
