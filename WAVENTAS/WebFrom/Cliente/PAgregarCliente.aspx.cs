using System;
using SWLNVENTAS;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebFrom_Cliente_PAgregarCliente : System.Web.UI.Page
{
    private CCliente cCliente = new CCliente();
    private EVCliente eVCliente = new EVCliente();

    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["CodigoCliente"] != null)
        //{
        //    //var usuario = cClienteVENTASDB.Obtener_VCliente_O(1);
        //    lblNombre.Text = usuario.NombresUsuario + " " + usuario.ApellidosUsuario;
        //    lblContacto.Text = usuario.CelularUsuario;
        //    lblCorreo.Text = usuario.CorreoUsuario;
        //    lblClave.Text = usuario.ClaveUsuario;
        //    lblEstado.Text = usuario.Estado;
        //}datagrid o gridview 3 lineas de codigo
    }
    protected void btnAgregarCliente_Click(object sender, EventArgs e)
    {
        int codigoCliente = cCliente.Obtener_VCliente_O_SiguienteCodigoCliente();
        cCliente.Insertar_VCliente_I(codigoCliente, txbRazonSocialCliente.Text, txbCiONitCliente.Text, ddlTipoCliente.Text, txbDirecionCliente.Text, txbCelularCliente.Text);
        lblInsercion.Text = "Agregado con exito";
    }
    protected void btnBuscarCliente_Click(object sender, EventArgs e)
    {

        if (int.Parse(txbCodigoCliente.Text) > 0)
        {
            eVCliente = cCliente.Obtener_VCliente_O(int.Parse(txbCodigoCliente.Text));
            if (eVCliente != null)
            {
                lbObtenerCliente.Text = "  RazonSocial Cliente: " + eVCliente.RazonSocialCliente + " CI o NIT: " + eVCliente.CiONitCliente + "  TipoProveedor: " + eVCliente.TipoCliente + "  DireccionCliente: " + eVCliente.DirecionCliente + "  CelularCliente: " + eVCliente.CelularCliente;
                txbRazonSocialClienteActualizar.Text = eVCliente.RazonSocialCliente;
                txbCiONitClienteActualizar.Text = eVCliente.CiONitCliente;
                txbTipoClienteActualizar.Text = eVCliente.TipoCliente;
                txbDireccActualizar.Text = eVCliente.DirecionCliente;
                txbCelularClienteActualizar.Text = eVCliente.CelularCliente;
                txbEstadoActualizar.Text = eVCliente.Estado;
            }
            else
            {
                lbObtenerCliente.Text = " ";
            }
        }
    }
  
    protected void btnActualizarCliente_Click(object sender, EventArgs e)
    {
        cCliente.Actualizar_VCliente_A(int.Parse(txbCodigoCliente.Text), txbRazonSocialClienteActualizar.Text, txbCiONitClienteActualizar.Text, txbTipoClienteActualizar.Text, txbDireccActualizar.Text, txbCelularClienteActualizar.Text, txbEstadoActualizar.Text);
    }
    protected void btnBuscarClienteEliminar_Click(object sender, EventArgs e)
    {
        if (int.Parse(txbCodigoClienteEliminar.Text) > 0)
        {
            cCliente.Eliminar_VCliente_E(int.Parse(txbCodigoClienteEliminar.Text));
        }
    }


}