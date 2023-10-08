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
    #region Tabla: VCliente

    public int Obtener_VCliente_O_SiguienteCodigoCliente()
    {
        CVENTAS cVENTAS = new CVENTAS();
        return cVENTAS.Obtener_VCliente_O_SiguienteCodigoCliente();
    }
    public void Insertar_VCliente_I(int codigoCliente, string razonSocialCliente, string ciONitCliente, string tipoCliente, string direcionCliente, string celularCliente)
    {
        CVENTAS cVENTAS = new CVENTAS();
        cVENTAS.Insertar_VCliente_I(codigoCliente, razonSocialCliente, ciONitCliente, tipoCliente, direcionCliente, celularCliente);
    }
    public EVCliente Obtener_VCliente_O(int codigoCliente)
    {
        CVENTAS cVENTAS = new CVENTAS();
        return cVENTAS.Obtener_VCliente_O(codigoCliente);
    }
    public void Actualizar_VCliente_A(int codigoCliente, string razonSocialCliente, string ciONitCliente, string tipoCliente, string direcionCliente, string celularCliente, string estado)
    {
        CVENTAS cVENTAS = new CVENTAS();
        cVENTAS.Actualizar_VCliente_A(codigoCliente, razonSocialCliente, ciONitCliente, tipoCliente, direcionCliente, celularCliente, estado);
    }
    public List<EVCliente> Obtener_VClientes_O_Todo()
    {
        CVENTAS cVENTAS = new CVENTAS();
        return cVENTAS.Obtener_VClientes_O_Todo();
    }
    public void Eliminar_VCliente_E(int codigoCliente)
    {
        CVENTAS cVENTAS = new CVENTAS();
        cVENTAS.Eliminar_VCliente_E(codigoCliente);
    }

    #endregion

    #region Registro Almacen
    public void Insertar_Ingreso(EIngreso ingreso, List<EDetalleIngreso> detalleIngresos)
    {
        CVENTAS cVENTAS = new CVENTAS();
        cVENTAS.Insertar_Ingreso(ingreso, detalleIngresos);
    }
    #endregion

    #region Tabla: 3

    #endregion

    #region Tabla: 4

    #endregion
}
