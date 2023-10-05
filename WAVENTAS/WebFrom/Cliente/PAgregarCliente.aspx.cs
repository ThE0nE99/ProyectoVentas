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
    #region Controladores
    CCliente cClienteVENTAS = new CCliente();
    #endregion

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
        CCliente cCliente = new CCliente();
        int codigoCliente = cCliente.Obtener_VCliente_O_SiguienteCodigoCliente();
        cCliente.Insertar_VCliente_I(codigoCliente, txbRazonSocialCliente.Text, txbCiONitCliente.Text, ddlTipoCliente.Text, txbDirecionCliente.Text,txbCelularCliente.Text);
        lblInsercion.Text = "Agregado con exito";
    }
    protected void btnBuscarCliente_Click(object sender, EventArgs e)
    {

        if (int.Parse(txbCodigoClienteActualizar.Text) > 0)
        {
            EVCliente eVcliente = cClienteVENTAS.Obtener_VCliente_O(int.Parse(txbCodigoClienteActualizar.Text));
            if (eVcliente != null)
            {
                EVCliente eVCliente = cClienteVENTAS.Obtener_VCliente_O(int.Parse(txbCodigoClienteActualizar.Text));
                lbObtenerCliente.Text = "  RazonSocial Cliente: " + eVCliente.RazonSocialCliente + " CI o NIT: " + eVCliente.CiONitCliente + "  TipoProveedor: " + eVCliente.TipoCliente + "  DireccionCliente: " + eVCliente.DirecionCliente + "  CelularCliente: " + eVCliente.CelularCliente ;
            }
        }
    }
    protected void btnBuscarClienteActualizar_Click(object sender, EventArgs e)
    {
        if (int.Parse(txbCodigoClienteActualizar.Text) > 0)
        {
            EVCliente eVcliente = cClienteVENTAS.Obtener_VCliente_O(int.Parse(txbCodigoClienteActualizar.Text));
            if (eVcliente != null)
            {
                EVCliente eVCliente = cClienteVENTAS.Obtener_VCliente_O(int.Parse(txbCodigoClienteActualizar.Text));
                txbRazonSocialClienteActualizar.Text = eVCliente.RazonSocialCliente;
                txbCiONitClienteActualizar.Text = eVCliente.CiONitCliente;
                txbTipoClienteActualizar.Text = eVCliente.TipoCliente;
                txbDireccActualizar.Text = eVCliente.DirecionCliente;
                txbCelularClienteActualizar.Text = eVCliente.CelularCliente;
            }
        }
    }
    protected void btnActualizarCliente_Click(object sender, EventArgs e)
    {
        cClienteVENTAS.Actualizar_VCliente_A(int.Parse(txbCodigoClienteActualizar.Text), txbRazonSocialClienteActualizar.Text, txbCiONitCliente.Text, txbTipoClienteActualizar.Text, txbDireccActualizar.Text, txbCelularClienteActualizar.Text, txbEstadoActualizar.Text);
    }
    protected void btnBuscarClienteEliminar_Click(object sender, EventArgs e)
    {
        if (int.Parse(txbCodigoClienteEliminar.Text) > 0)
        {
            EVCliente articulo = cClienteVENTAS.Obtener_VCliente_O(int.Parse(txbCodigoClienteEliminar.Text));
            if (articulo != null)
            {
                cClienteVENTAS.Obtener_VCliente_O(int.Parse(txbCodigoClienteEliminar.Text));
            }
        }
    }


}