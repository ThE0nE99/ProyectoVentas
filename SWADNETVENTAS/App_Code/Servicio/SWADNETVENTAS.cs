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

    #region Tabla: VCliente
    public int Obtener_VCliente_O_SiguienteCodigoCliente()
    {
        CVCliente cVCliente = new CVCliente();
        return cVCliente.Obtener_VCliente_O_SiguienteCodigoCliente();
    }
    public void Insertar_VCliente_I(EVCliente cliente)
    {
        CVCliente cVCliente = new CVCliente();
        cVCliente.Insertar_VCliente_I(cliente);
    }
    public EVCliente Obtener_VCliente_O(int codigoCliente)
    {
        CVCliente cVCliente = new CVCliente();
        return cVCliente.Obtener_VCliente_O(codigoCliente);
    }
    public void Actualizar_VCliente_A(EVCliente cliente)
    {
        CVCliente cVCliente = new CVCliente();
        cVCliente.Actualizar_VCliente_A(cliente);
    }
    public List<EVCliente> Obtener_VClientes_O_Todo()
    {
        CVCliente cVCliente = new CVCliente();
        return cVCliente.Obtener_VClientes_O_Todo();
    }
    public void Eliminar_VCliente_E(int codigoCliente)
    {
        CVCliente cVCliente = new CVCliente();
        cVCliente.Eliminar_VCliente_E(codigoCliente);
    }
    #endregion
    #region Tabla: VDetalleIngreso
    public int Obtener_VDetalleIngreso_O_SiguienteCodigoDetalleIngreso()
    {
        CVDetalleIngreso cVDetalleIngreso = new CVDetalleIngreso();
        return cVDetalleIngreso.Obtener_VDetalleIngreso_O_SiguienteDetalleIngreso();
    }
    public void Insertar_VDetalleIngreso_I(EVDetalleIngreso detalle)
    {
        CVDetalleIngreso cVDetalleIngreso = new CVDetalleIngreso();
        cVDetalleIngreso.Insertar_VDetalleIngreso_I(detalle);
    }
    public EVDetalleIngreso Obtener_VDetalleIngreso_O(int codigoDetalle)
    {
        CVDetalleIngreso cVDetalleIngreso = new CVDetalleIngreso();
        return cVDetalleIngreso.Obtener_VDetalleIngreso_O(codigoDetalle);
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
