using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using SWADNETVENTAS;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class SWLNVENTAS : ISWLNVENTAS
{
    #region Tabla: VArticulo
    public int Obtener_VArticulo_O_SiguienteCodigoArticulo()
    {
        CVENTAS cVENTAS = new CVENTAS();
        return cVENTAS.Obtener_VArticulo_O_SiguienteCodigoArticulo();
    }
    public void Insertar_VArticulo_I(int codigoArticulo, string categoriaArticulo, string nombreArticulo, double precioCompraArticulo, double precioVentaArticulo, int stockArticulo)
    {
        CVENTAS cVENTAS = new CVENTAS();
        cVENTAS.Insertar_VArticulo_I(codigoArticulo, categoriaArticulo, nombreArticulo, precioCompraArticulo, precioVentaArticulo, stockArticulo);
    }

    public EVArticulo Obtener_VArticulo_O(int codigoArticulo)
    {
        CVENTAS cVENTAS = new CVENTAS();
        EVArticulo eVArticulo = new EVArticulo();
        eVArticulo = cVENTAS.Obtener_VArticulo_O(codigoArticulo);
        return eVArticulo;
    }
    public void Actualizar_VArticulo_A(int codigoArticulo, string categoriaArticulo, string nombreArticulo, double precioCompraArticulo, double precioVentaArticulo, int stockArticulo)
    {
        CVENTAS cVENTAS = new CVENTAS();
        cVENTAS.Actualizar_VArticulo_A(codigoArticulo, categoriaArticulo, nombreArticulo, precioCompraArticulo, precioVentaArticulo, stockArticulo);
    }
    public List<EVArticulo> Obtener_VArticulo_O_Todo()
    {
        CVENTAS cVENTAS = new CVENTAS();
        List<EVArticulo> lstEVArticulos = new List<EVArticulo>();
        lstEVArticulos = cVENTAS.Obtener_VArticulo_O_Todo();
        return lstEVArticulos;
    }
    public void Eliminar_VArticulo_E(int codigoArticulo)
    {
        CVENTAS cVENTAS = new CVENTAS();
        cVENTAS.Eliminar_VArticulo_E(codigoArticulo);
    }
    #endregion

    #region Tabla: 2

    #endregion

    #region Tabla: 3

    #endregion

    #region Tabla: 4

    #endregion
}
