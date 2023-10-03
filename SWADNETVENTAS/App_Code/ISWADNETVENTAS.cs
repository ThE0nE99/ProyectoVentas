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


    #region Tabla: 2

    #endregion

    #region Tabla: 3

    #endregion

    #region Tabla: 4

    #endregion
}
