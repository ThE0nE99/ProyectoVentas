using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class SWADNETVENTAS : ISWADNETVENTAS
{
    #region Tabla: 1

    #endregion
    #region Tabla: VDetalleVenta
    public int Obtener_VDetalleVenta_O_SiguienteCodigoDetalleVenta()
    {
        CVDetalleVenta cVDetalleVenta = new CVDetalleVenta();
        return cVDetalleVenta.Obtener_VDetalleVenta_O_SiguienteCodigoDetalleVenta();
    }
    public void Insertar_VDetalleVenta_I(EVDetalleVenta detalleVenta)
    {
        CVDetalleVenta cVDetalleVenta = new CVDetalleVenta();
        cVDetalleVenta.Insertar_VDetalleVenta_I(detalleVenta);
    }
    public List<EVDetalleVenta> Obtener_VDetalleVenta_O_CodigoVenta(int codigoVenta)
    {
        CVDetalleVenta cVDetalleVenta = new CVDetalleVenta();
        return cVDetalleVenta.Obtener_VDetalleVenta_O_CodigoVenta(codigoVenta);
    }
    #endregion

    #region Tabla: VVenta
    // Obtener último id
    public int Obtener_VVenta_O_SiguienteCodigoVenta()
    {
        CVVenta cVVenta = new CVVenta();
        return cVVenta.Obtener_VVenta_O_SiguienteCodigoVenta();
    }
    // Insertar
    public void Insertar_VVenta_I(EVVenta venta)
    {
        CVVenta cVVenta = new CVVenta();
        cVVenta.Insertar_VVenta_I(venta);
    }
    // Obtener un registro
    public List<EVVenta> Obtener_VVenta_O(int codigoVenta)
    {
        CVVenta cVUsuario = new CVVenta();
        return cVUsuario.Obtener_VVenta_O(codigoVenta);
    }
    #endregion

    #region Tabla: VUsuario
    // Obtener último id
    public int Obtener_VUsuario_O_SiguienteCodigoUsuario()
    {
        CVUsuario cVUsuario = new CVUsuario();
        return cVUsuario.Obtener_VUsuario_O_SiguienteCodigoUsuario();
    }
    // Insertar
    public void Insertar_VUsuario_I(EVUsuario usuario)
    {
        CVUsuario cVUsuario = new CVUsuario();
        cVUsuario.Insertar_VUsuario_I(usuario);
    }
    // Obtener un registro
    public EVUsuario Obtener_VUsuario_O(int codigoUsuario)
    {
        CVUsuario cVUsuario = new CVUsuario();
        return cVUsuario.Obtener_VUsuario_O(codigoUsuario);
    }
    // Actualizar
    public void Actualizar_VUsuario_A(EVUsuario usuario)
    {
        CVUsuario cVUsuario = new CVUsuario();
        cVUsuario.Actualizar_VUsuario_A(usuario);
    }
    // Obtener todos los registros
    public List<EVUsuario> Obtener_VUsuario_O_Todo()
    {
        CVUsuario cVUsuario = new CVUsuario();
        return cVUsuario.Obtener_VUsuario_O_Todo();
    }
    // Eliminar
    public void Eliminar_VUsuario_E(int codigoUsuario)
    {
        CVUsuario cVUsuario = new CVUsuario();
        cVUsuario.Eliminar_VUsuario_E(codigoUsuario);
    }
    #endregion

    #region Tabla: 4

    #endregion
}
