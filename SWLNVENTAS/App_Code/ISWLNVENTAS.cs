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

    #region Tabla: 2

    #endregion

    #region Tabla: 3

    #endregion

    #region Tabla: 4

    #endregion
}

