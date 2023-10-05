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
    #region Tabla: VProveedor
    public int Obtener_VProveedor_O_SiguienteCodigoProveedor()
    {
        CVProveedor cVProveedor = new CVProveedor();
        return cVProveedor.Obtener_VProveedor_O_SiguienteCodigoProveedor();
    }
    public void Insertar_VProveedor_I(EVProveedor proveedor)
    {
        CVProveedor cVProveedor = new CVProveedor();
        cVProveedor.Insertar_VProveedor_I(proveedor);
    }
    public EVProveedor Obtener_VProveedor_O(int codigoProveedor)
    {
        CVProveedor cVProveedor = new CVProveedor();
        return cVProveedor.Obtener_VProveedor_O(codigoProveedor);
    }
    public void Actualizar_VProveedor_A(EVProveedor proveedor)
    {
        CVProveedor cVProveedor = new CVProveedor();
        cVProveedor.Actualizar_VProveedor_A(proveedor);
    }
    public List<EVProveedor> Obtener_VProveedor_O_Todo()
    {
        CVProveedor cVProveedor = new CVProveedor();
        return cVProveedor.Obtener_VProveedor_O_Todo();
    }
    public void Eliminar_VProveedor_E(int codigoProveedor)
    {
        CVProveedor cVProveedor = new CVProveedor();
        cVProveedor.Eliminar_VProveedor_E(codigoProveedor);
    }
    #endregion

    #region Tabla: VIngreso
    public int Obtener_VIngreso_O_SiguienteCodigoIngreso()
    {
        CVIngreso cVIngreso = new CVIngreso();
        return cVIngreso.Obtener_VIngreso_O_SiguienteCodigoIngreso();
    }
    public void Insertar_VIngreso_I(EVIngreso ingreso)
    {
        CVIngreso cVIngreso = new CVIngreso();
        cVIngreso.Insertar_VIngreso_I(ingreso);
    }
    public EVIngreso Obtener_VIngreso_O_CodigoIngreso(int codigoIngreso)
    {
        CVIngreso cVIngreso = new CVIngreso();
        return cVIngreso.Obtener_VIngreso_O_CodigoIngreso(codigoIngreso);
    }
    public List<EVIngreso> Obtener_VIngreso_O_Todo()
    {
        CVIngreso cVIngreso = new CVIngreso();
        return cVIngreso.Obtener_VIngreso_O_Todo();
    }
    #endregion

    #region Tabla: 3

    #endregion

    #region Tabla: 4

    #endregion
}
