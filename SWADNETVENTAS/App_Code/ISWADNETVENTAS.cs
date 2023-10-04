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

    #region Tabla: VDetalleVenta
    [OperationContract]
    int Obtener_VDetalleVenta_O_SiguienteCodigoDetalleVenta();
    [OperationContract]
    void Insertar_VDetalleVenta_I(EVDetalleVenta detalleVenta);
    [OperationContract]
    List<EVDetalleVenta> Obtener_VDetalleVenta_O_CodigoVenta(int codigoVenta);
    #endregion

    #region Tabla: 3

    #endregion

    #region Tabla: 4

    #endregion
}
