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
    #region Tabla: 1

    #endregion

    #region Tabla: VDetalleVenta
    [OperationContract]
    int Obtener_VDetalleVenta_O_SiguienteCodigoDetalleVenta();
    [OperationContract]
    void Insertar_VDetalleVenta_I(EVDetalleVenta detalleVenta);
    [OperationContract]
    List<EVDetalleVenta> Obtener_VDetalleVenta_O_CodigoVenta(int codigoVenta);
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
    List<EVVenta>  Obtener_VVenta_O(int codigoUsuario);
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

    #region Tabla: 4

    #endregion
}
