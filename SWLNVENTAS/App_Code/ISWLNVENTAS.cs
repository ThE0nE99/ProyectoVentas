using SWADNETVENTAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ISWLNVENTAS
{
    #region Tabla: VProveedor

    [OperationContract]
    int Obtener_VProveedor_O_SiguienteCodigoProveedor();
    [OperationContract]
    void Insertar_VProveedor_I(int codigoProveedor, string tipoProveedor, string razonSocialProveedor, string direccionProveedor, string celularProveedor, string correoProveedor);
    [OperationContract]
    EVProveedor Obtener_VProveedor_O(int codigoProveedor);
    [OperationContract]
    void Actualizar_VProveedor_A(int codigoProveedor, string tipoProveedor, string razonSocialProveedor, string direccionProveedor, string celularProveedor, string correoProveedor,string estado);
    [OperationContract]
    List<EVProveedor> Obtener_VProveedor_O_Todo();
    [OperationContract]
    void Eliminar_VProveedor_E(int codigoProveedor);
    #endregion

    #region Tabla: VCliente
    [OperationContract]
    int Obtener_VCliente_O_SiguienteCodigoCliente();
    [OperationContract]
    void Insertar_VCliente_I(int codigoCliente, string razonSocialCliente, string ciONitCliente, string tipoCliente, string direcionCliente, string celularCliente);
    [OperationContract]
    EVCliente Obtener_VCliente_O(int codigoCliente);
    [OperationContract]
    void Actualizar_VCliente_A(int codigoCliente, string razonSocialCliente, string ciONitCliente, string tipoCliente, string direcionCliente, string celularCliente, string estado);
    [OperationContract]
    List<EVCliente> Obtener_VClientes_O_Todo();
    [OperationContract]
    void Eliminar_VCliente_E(int codigoCliente);
    #endregion

    #region Registro Almacen
    [OperationContract]
    void Insertar_Ingreso(EIngreso ingreso, List<EDetalleIngreso> detalleIngresos);
    #endregion

    #region Tabla: VArticulos
    [OperationContract]
    int Obtener_VArticulo_O_SiguienteCodigoArticulo();
    [OperationContract]
    void Insertar_VArticulo_I(int codigoArticulo, string categoriaArticulo, string nombreArticulo, double precioCompraArticulo, double precioVentaArticulo, int stockArticulo);
    [OperationContract]
    EVArticulo Obtener_VArticulo_O(int codigoArticulo);
    [OperationContract]
    void Actualizar_VArticulo_A(int codigoArticulo, string categoriaArticulo, string nombreArticulo, double precioCompraArticulo, double precioVentaArticulo, int stockArticulo);
    [OperationContract]
    List<EVArticulo> Obtener_VArticulo_O_Todo();
    [OperationContract]
    void Eliminar_VArticulo_E(int codigoArticulo);

    #endregion

    #region Registo de la Venta

    // Insertar
    [OperationContract]
    void Insertar_Venta(EVenta eVenta, List<EDetalleVenta> lstDetalleVentas);

    #endregion

    #region Tabla: VUsuario
    // Obtener último id
    [OperationContract]
    int Obtener_VUsuario_O_SiguienteCodigoUsuario();
    // Insertar
    [OperationContract]
    void Insertar_VUsuario_I(int codigoUsuario, string nombresUsuario, string apellidosUsuario, string celularUsuario, string correoUsuario, string claveUsuario, string rolUsuario);
    // Obtener un registro
    [OperationContract]
    EVUsuario Obtener_VUsuario_O(int codigoUsuario);
    // Actualizar
    [OperationContract]
    void Actualizar_VUsuario_A(int codigoUsuario, string nombresUsuario, string apellidosUsuario, string celularUsuario, string correoUsuario, string claveUsuario, string rolUsuario, string estado);
    // Obtener todos los registros
    [OperationContract]
    List<EVUsuario> Obtener_VUsuario_O_Todo();
    // Eliminar
    [OperationContract]
    void Eliminar_VUsuario_E(int codigoUsuario);
    #endregion
}

