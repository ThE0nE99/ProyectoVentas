using SWLNVENTAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebFrom_Usuario_PAgregarUsuario : System.Web.UI.Page
{
    #region Controladores

    CUsuario cUsuarioVENTASDB = new CUsuario();
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            OcultarCamposEdicion();
        }
    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        CUsuario cUsuario = new CUsuario();
        int codigoUsuario = cUsuario.Obtener_VUsuario_O_SiguienteCodigoUsuario();
        cUsuario.Insertar_VUsuario_I(codigoUsuario, txtNombres.Text, txtApellidos.Text, txtCelular.Text, txtCorreo.Text, txtClave.Text, CmbRol.Text);
    }
    protected void btnVerDatos_Click(object sender, EventArgs e)
    {
        var usuarios = cUsuarioVENTASDB.Obtener_VUsuario_O_Todo();
        var idBuscadoStr = txtId.Text;
        if (int.TryParse(idBuscadoStr, out int idBuscado))
        {
            var usuario = usuarios.FirstOrDefault(u => u.CodigoUsuario == idBuscado);

            if (usuario != null)
            {
                lblNombre.Text = "Nombre Completo: " + usuario.NombresUsuario + " " + usuario.ApellidosUsuario;
                lblContacto.Text = "Celular:" + usuario.CelularUsuario;
                lblCorreo.Text = "Correo: " + usuario.CorreoUsuario;
                lblClave.Text = "Clave: " + usuario.ClaveUsuario;
                lblEstado.Text = "Estado:" + usuario.Estado;
            }
            else
            {
                lblNombre.Text = "Usuario no encontrado";
                lblContacto.Text = "";
                lblCorreo.Text = "";
                lblClave.Text = "";
                lblEstado.Text = "";
            }
        }
        else
        {
            lblNombre.Text = "ID no válido";
            lblContacto.Text = "";
            lblCorreo.Text = "";
            lblClave.Text = "";
            lblEstado.Text = "";
        }
    }
    protected void btnEditar_Click(object sender, EventArgs e)
    {
        int codigoUsuario = int.Parse(txtIdEditar.Text);
        CUsuario cUsuario = new CUsuario();
        cUsuario.Actualizar_VUsuario_A(codigoUsuario, txtNombresEditar.Text, txtApellidosEditar.Text, txtCelularEditar.Text, txtCorreoEditar.Text, txtClaveEditar.Text, ddlRolEditar.Text, txtEstadoEditar.Text);
    }
    protected void btnBuscarEditar_Click(object sender, EventArgs e)
    {
        var usuarios = cUsuarioVENTASDB.Obtener_VUsuario_O_Todo();
        var idBuscadoStr = txtIdEditar.Text; 

        if (int.TryParse(idBuscadoStr, out int idBuscado))
        {
            var usuario = usuarios.FirstOrDefault(u => u.CodigoUsuario == idBuscado);

            if (usuario != null)
            {
                MostrarCamposEdicion();
                txtNombresEditar.Text = usuario.NombresUsuario;
                txtApellidosEditar.Text = usuario.ApellidosUsuario;
                txtCelularEditar.Text = usuario.CelularUsuario;
                txtCorreoEditar.Text = usuario.CorreoUsuario;
                txtClaveEditar.Text = usuario.ClaveUsuario;
                ddlRolEditar.Text = usuario.RolUsuario;
                txtEstadoEditar.Text = usuario.Estado;
            }
            else
            {
                OcultarCamposEdicion();
                txtNombresEditar.Visible = true;
                txtNombresEditar.Text = "Usuario no encontrado";
            }
        }
        else
        {
            OcultarCamposEdicion();
            txtNombresEditar.Visible = true;
            txtNombresEditar.Text = "ID no válido";
        }
    }
    private void OcultarCamposEdicion()
    {
        txtNombresEditar.Visible = false;
        txtApellidosEditar.Visible = false;
        txtCelularEditar.Visible = false;
        txtCorreoEditar.Visible = false;
        txtClaveEditar.Visible = false;
        ddlRolEditar.Visible = false;
        txtEstadoEditar.Visible = false;
        btnEditar.Visible = false;
    }
    private void MostrarCamposEdicion()
    {
        txtNombresEditar.Visible = true;
        txtApellidosEditar.Visible = true;
        txtCelularEditar.Visible = true;
        txtCorreoEditar.Visible = true;
        txtClaveEditar.Visible = true;
        ddlRolEditar.Visible = true;
        txtEstadoEditar.Visible = true;
        btnEditar.Visible = true;
    }
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        var usuarios = cUsuarioVENTASDB.Obtener_VUsuario_O_Todo();
        var idBuscadoStr = txtIdEliminar.Text; 
        if (int.TryParse(idBuscadoStr, out int idBuscado))
        {
            var usuario = usuarios.FirstOrDefault(u => u.CodigoUsuario == idBuscado);

            if (usuario != null)
            {
                // Si se encuentra el usuario, mostrar sus propiedades
                txtEliminarInformacion.Text = usuario.NombresUsuario + " " + usuario.ApellidosUsuario + " Eliminado ";
                int codigoUsuario = int.Parse(txtIdEliminar.Text);                                           
                CUsuario cUsuario = new CUsuario();
                cUsuario.Eliminar_VUsuario_E(codigoUsuario);

            }
            else
            {
                txtEliminarInformacion.Text = "Usuario no encontrado";
            }
        }
        else
        {
            txtEliminarInformacion.Text = "ID no válido";
        }
    }

    protected void btnVerUsuaarios_Click(object sender, EventArgs e)
    {
        CUsuario cUsuario = new CUsuario();
        List<EVUsuario> lstEVUsuarios = cUsuario.Obtener_VUsuario_O_Todo();
        gridViewUsuarios.DataSource = lstEVUsuarios;
        gridViewUsuarios.DataBind();
    }

	protected void btnMenu_Click(object sender, EventArgs e)
	{
		Response.Redirect("~/WebFrom/Menu/Default.aspx");
	}
}