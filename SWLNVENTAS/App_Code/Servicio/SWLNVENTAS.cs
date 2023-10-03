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
    #region Tabla: VProveedor
    public int Obtener_VProveedor_O_SiguienteCodigoProveedor()
    {
        CVENTAS cVENTAS = new CVENTAS();
        return cVENTAS.Obtener_VProveedor_O_SiguienteCodigoProveedor();
    }
    public void Insertar_VProveedor_I(int codigoProveedor, string tipoProveedor, string razonSocialProveedor, string direccionProveedor, string celularProveedor, string correoProveedor)
    {
        CVENTAS cVENTAS = new CVENTAS();
        cVENTAS.Insertar_VProveedor_I(codigoProveedor, tipoProveedor, razonSocialProveedor, direccionProveedor, celularProveedor, correoProveedor);
    }

    public EVProveedor Obtener_VProveedor_O(int codigoProveedor)
    {
        CVENTAS cVENTAS = new CVENTAS();
        return cVENTAS.Obtener_VProveedor_O(codigoProveedor);
    }

    public void Actualizar_VProveedor_A(int codigoProveedor, string tipoProveedor, string razonSocialProveedor, string direccionProveedor, string celularProveedor, string correoProveedor)
    {
        CVENTAS cVENTAS = new CVENTAS();
        cVENTAS.Actualizar_VProveedor_A(codigoProveedor, tipoProveedor, razonSocialProveedor, direccionProveedor, celularProveedor, correoProveedor);

    }
    public List<EVProveedor> Obtener_VProveedor_O_Todo()
    {
        CVENTAS cVENTAS = new CVENTAS();
        return cVENTAS.Obtener_VProveedor_O_Todo();
    }

    public void Eliminar_VProveedor_E(int codigoProveedor)
    {
        CVENTAS cVENTAS = new CVENTAS();
        cVENTAS.Eliminar_VProveedor_E(codigoProveedor);
    }
    #endregion

    #region Tabla: 2

    #endregion

    #region Tabla: 3

    #endregion

    #region Tabla: 4

    #endregion
}
