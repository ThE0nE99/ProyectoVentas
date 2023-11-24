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

    public void Actualizar_VProveedor_A(int codigoProveedor, string tipoProveedor, string razonSocialProveedor, string direccionProveedor, string celularProveedor, string correoProveedor, string estado)
    {
        CVENTAS cVENTAS = new CVENTAS();
        cVENTAS.Actualizar_VProveedor_A(codigoProveedor, tipoProveedor, razonSocialProveedor, direccionProveedor, celularProveedor, correoProveedor,estado);

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
}
