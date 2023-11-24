using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ISWADNETVENTAS
{
    #region Tabla: VProveedor
    [OperationContract]
    int Obtener_VProveedor_O_SiguienteCodigoProveedor();
    [OperationContract]
    void Insertar_VProveedor_I(EVProveedor proveedor);
    [OperationContract]
    EVProveedor Obtener_VProveedor_O(int codigoProveedor);
    [OperationContract]
    void Actualizar_VProveedor_A(EVProveedor proveedor);
    [OperationContract]
    List<EVProveedor> Obtener_VProveedor_O_Todo();
    [OperationContract]
    void Eliminar_VProveedor_E(int codigoProveedor);
    #endregion

    #region Tabla: VCliente

    [OperationContract]
    int Obtener_VCliente_O_SiguienteCodigoCliente();
    [OperationContract]
    void Insertar_VCliente_I(EVCliente cliente);
    [OperationContract]
    EVCliente Obtener_VCliente_O(int codigoCliente);
    [OperationContract]
    void Actualizar_VCliente_A(EVCliente cliente);
    [OperationContract]
    List<EVCliente> Obtener_VClientes_O_Todo();
    [OperationContract]
    void Eliminar_VCliente_E(int codigoCliente);
    #endregion

    #region Tabla: VArticulo
    [OperationContract]
    int Obtener_VArticulo_O_SiguienteCodigoArticulo();
    [OperationContract]
    void Insertar_VArticulo_I(EVArticulo articulo);
    [OperationContract]
    EVArticulo Obtener_VArticulo_O(int codigoArticulo);
    [OperationContract]
    void Actualizar_VArticulo_A(EVArticulo articulo);
    [OperationContract]
    List<EVArticulo> Obtener_VArticulo_O_Todo();
    [OperationContract]
    void Eliminar_VArticulo_E(int codigoArticulo);
    #endregion

    #region Tabla: VUsuario
    // Obtener último id
    [OperationContract]
    int Obtener_VUsuario_O_SiguienteCodigoUsuario();
    // Insertar
    [OperationContract]
    void Insertar_VUsuario_I(EVUsuario usuario);
    // Obtener un registro
    [OperationContract]
    EVUsuario Obtener_VUsuario_O(int codigoUsuario);
    // Actualizar
    [OperationContract]
    void Actualizar_VUsuario_A(EVUsuario usuario);
    // Obtener todos los registros
    [OperationContract]
    List<EVUsuario> Obtener_VUsuario_O_Todo();
    // Eliminar
    [OperationContract]
    void Eliminar_VUsuario_E(int codigoUsuario);
    #endregion

    #region Tabla: VVenta
    // Obtener último id
    [OperationContract]
    int Obtener_VVenta_O_SiguienteCodigoVenta();
    // Insertar
    [OperationContract]
    void Insertar_VVenta_I(EVVenta usuario);
    // Obtener un registro
    [OperationContract]
    List<EVVenta> Obtener_VVenta_O(int codigoUsuario);
    // Actualizar
    /*
    [OperationContract]
    void Actualizar_VUsuario_A(EVUsuario usuario);
    // Obtener todos los registros
    [OperationContract]
    List<EVUsuario> Obtener_VUsuario_O_Todo();
    // Eliminar
    [OperationContract]
    void Eliminar_VUsuario_E(int codigoUsuario);*/
    #endregion

    #region Tabla: VIngreso
    [OperationContract]
    int Obtener_VIngreso_O_SiguienteCodigoIngreso();
    [OperationContract]
    void Insertar_VIngreso_I(EVIngreso ingreso);
    [OperationContract]
    EVIngreso Obtener_VIngreso_O(int codigoIngreso);
    [OperationContract]
    List<EVIngreso> Obtener_VIngreso_O_Todo();
    #endregion

    #region Tabla: VDetalleIngreso

    [OperationContract]
    int Obtener_VDetalleIngreso_O_SiguienteCodigoDetalleIngreso();
    [OperationContract]
    void Insertar_VDetalleIngreso_I(EVDetalleIngreso detalle);
    [OperationContract]
    EVDetalleIngreso Obtener_VDetalleIngreso_O_CodigoIngreso(int codigoIngreso);

    #endregion

    #region Tabla: VDetalleVenta
    [OperationContract]
    int Obtener_VDetalleVenta_O_SiguienteCodigoDetalleVenta();
    [OperationContract]
    void Insertar_VDetalleVenta_I(EVDetalleVenta detalleVenta);
    [OperationContract]
    List<EVDetalleVenta> Obtener_VDetalleVenta_O_CodigoVenta(int codigoVenta);
    #endregion
}
