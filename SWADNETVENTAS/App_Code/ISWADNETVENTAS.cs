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

    #region Tabla: VIngreso
    [OperationContract]
    int Obtener_VIngreso_O_SiguienteCodigoIngreso();
    [OperationContract]
    void Insertar_VIngreso_I(EVIngreso ingreso);
    [OperationContract]
    EVIngreso Obtener_VIngreso_O_CodigoIngreso(int codigoIngreso);
    [OperationContract]
    List<EVIngreso> Obtener_VIngreso_O_Todo();

   
    #endregion

    #region Tabla: 3

    #endregion

    #region Tabla: 4

    #endregion
}
