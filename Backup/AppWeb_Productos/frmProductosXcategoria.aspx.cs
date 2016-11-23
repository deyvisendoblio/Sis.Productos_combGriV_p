using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Productos.Libreria.Negocios;
using System.Data;
using System.Windows.Forms;

namespace AppWeb_Productos
{
    
    public partial class frmProductosXcategoria : System.Web.UI.Page
    {
        ProductosN objNegocio = new ProductosN();
     

        protected void Page_Load(object sender, EventArgs e)
        {
            // si el formulario se esta volviendo a cargar
            // entonces retornamos (no continuamos)
        if (Page.IsPostBack==true) 
            return;
            
        // caso contrario, es 1ra vez que carga el formulario
        ddlCategoria.DataTextField = "CategoryName";
        ddlCategoria.DataValueField = "CategoryID";
        ddlCategoria.DataSource = objNegocio.Listar_Categorias();
        ddlCategoria.DataBind();
        int c;
        }

        

        protected void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //RECUPERA EL CODIGO DE LA CATEGORIA
           int   COD = int.Parse ( ddlCategoria.SelectedValue );
           
          dgvProductos.DataSource = objNegocio.Productos_Categoria(COD);
          dgvProductos.DataBind(); 
  
        }


        
        protected void dgvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

            GridViewRow row = dgvProductos.SelectedRow;

            Session["c"] = int.Parse(row.Cells[2].Text);
            
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                objNegocio.actualiza_stock(Convert .ToInt16 ( Session["c"]), int.Parse(txtStock.Text));
                MessageBox.Show("ok");
                ddlCategoria_SelectedIndexChanged(sender, e);
            }
            catch (Exception )
            {

                throw;
                }



        }

        }
}