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

    #region Tabla: 2

    #endregion

    #region Tabla: 3

    #endregion

    #region Tabla: 4

    #endregion
}
