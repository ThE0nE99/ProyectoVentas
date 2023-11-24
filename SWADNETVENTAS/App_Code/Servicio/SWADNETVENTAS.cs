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
    public EVIngreso Obtener_VIngreso_O(int codigoIngreso)
    {
        CVIngreso cVIngreso = new CVIngreso();
        return cVIngreso.Obtener_VIngreso_O(codigoIngreso);
    }
    public List<EVIngreso> Obtener_VIngreso_O_Todo()
    {
        CVIngreso cVIngreso = new CVIngreso();
        return cVIngreso.Obtener_VIngreso_O_Todo();
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
    public EVDetalleIngreso Obtener_VDetalleIngreso_O_CodigoIngreso(int codigoIngreso)
    {
        CVDetalleIngreso cVDetalleIngreso = new CVDetalleIngreso();
        return cVDetalleIngreso.Obtener_VDetalleIngreso_O_CodigoIngreso(codigoIngreso);
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
}
