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

    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        CUsuario cUsuario = new CUsuario();
        int codigoUsuario = cUsuario.Obtener_VUsuario_O_SiguienteCodigoUsuario();
        cUsuario.Insertar_VUsuario_I(codigoUsuario, txtNombres.Text, txtApellidos.Text, txtCelular.Text, txtCorreo.Text, txtClave.Text, "ES");
    }
}