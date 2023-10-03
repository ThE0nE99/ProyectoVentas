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

    #region Tabla: 2

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
