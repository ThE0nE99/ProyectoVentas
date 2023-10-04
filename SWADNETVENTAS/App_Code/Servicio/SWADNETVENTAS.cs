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
    #region Tabla: VArticulo
    public int Obtener_VArticulo_O_SiguienteCodigoArticulo()
    {
        CVArticulo cVArticulo = new CVArticulo();
        return cVArticulo.Obtener_VArticulo_O_SiguienteCodigoArticulo();
    }
    public void Insertar_VArticulo_I(EVArticulo articulo)
    {
        CVArticulo cVArticulo = new CVArticulo();
        cVArticulo.Insertar_VArticulo_I(articulo);
    }
    public EVArticulo Obtener_VArticulo_O(int codigoArticulo)
    {
        CVArticulo cVArticulo = new CVArticulo();
        return cVArticulo.Obtener_VArticulo_O(codigoArticulo);
    }
    public void Actualizar_VArticulo_A(EVArticulo articulo)
    {
        CVArticulo cVArticulo = new CVArticulo();
        cVArticulo.Actualizar_VArticulo_A(articulo);
    }
    public List<EVArticulo> Obtener_VArticulo_O_Todo()
    {
        CVArticulo cVArticulo = new CVArticulo();
        return cVArticulo.Obtener_VArticulo_O_Todo();
    }
    public void Eliminar_VArticulo_E(int codigoArticulo)
    {
        CVArticulo cVArticulo = new CVArticulo();
        cVArticulo.Eliminar_VArticulo_e(codigoArticulo);
    }
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

    #region Tabla: 3

    #endregion

    #region Tabla: 4

    #endregion
}
