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
    #region Tabla: 1

    #endregion

    #region Tabla: 2

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

    #region Tabla: 4

    #endregion
}
