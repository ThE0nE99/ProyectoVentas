using SWADNETVENTAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class SWLNVENTAS : ISWLNVENTAS
{
    #region Tabla: 1

    #endregion

    #region Tabla: 2

    #endregion
    #region Registo de la Venta
    // Insertar
    public void Insertar_Venta(EVenta eVenta, List<EDetalleVenta> lstDetalleVentas)
    {
        CVENTAS cVENTAS = new CVENTAS();
        cVENTAS.Insertar_Venta(eVenta, lstDetalleVentas);
    }
    #endregion

    #region Tabla: VUsuario
    // Obtener último id
    public int Obtener_VUsuario_O_SiguienteCodigoUsuario()
    {
        CVENTAS cVENTAS = new CVENTAS();
        return cVENTAS.Obtener_VUsuario_O_SiguienteCodigoUsuario();
    }
    // Insertar
    public void Insertar_VUsuario_I(int codigoUsuario, string nombresUsuario, string apellidosUsuario, string celularUsuario, string correoUsuario, string claveUsuario, string rolUsuario)
    {
        CVENTAS cVENTAS = new CVENTAS();
        cVENTAS.Insertar_VUsuario_I(codigoUsuario, nombresUsuario, apellidosUsuario, celularUsuario, correoUsuario, claveUsuario, rolUsuario);
    }
    // Obtener un registro

    public EVUsuario Obtener_VUsuario_O(int codigoUsuario)
    {
        CVENTAS cVENTAS = new CVENTAS();
        return cVENTAS.Obtener_VUsuario_O(codigoUsuario);
    }
    // Actualizar
    public void Actualizar_VUsuario_A(int codigoUsuario, string nombresUsuario, string apellidosUsuario, string celularUsuario, string correoUsuario, string claveUsuario, string rolUsuario, string estado)
    {
        CVENTAS cVENTAS = new CVENTAS();
        cVENTAS.Actualizar_VUsuario_A(codigoUsuario, nombresUsuario, apellidosUsuario, celularUsuario, correoUsuario, claveUsuario, rolUsuario, estado);
    }
    // Obtener todos los registros
    public List<EVUsuario> Obtener_VUsuario_O_Todo()
    {
        CVENTAS cVENTAS = new CVENTAS();
        return cVENTAS.Obtener_VUsuario_O_Todo();
    }
    // Eliminar
    public void Eliminar_VUsuario_E(int codigoUsuario)
    {
        CVENTAS cVENTAS = new CVENTAS();
        cVENTAS.Eliminar_VUsuario_E(codigoUsuario);
    }
    #endregion

    #region Tabla: 4

    #endregion
}
