using SWLNVENTAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CUsuario
/// </summary>
public class CUsuario
{
    #region Atributos
    private LNServicio lnServicio;
    #endregion

    #region Propiedades
    public string NombreClase
    {
        get { return GetType().Name; }
    }
    #endregion

    #region Constructor
    public CUsuario()
    {
        lnServicio = new LNServicio();
    }
    #endregion

    #region Metodos Publicos
    // Obtener último id
    public int Obtener_VUsuario_O_SiguienteCodigoUsuario()
    {
        try
        {
            return lnServicio.Obtener_VUsuario_O_SiguienteCodigoUsuario();

        }
        catch (Exception)
        {
            throw;
        }
    }
    // Insertar
    public void Insertar_VUsuario_I(int codigoUsuario, string nombresUsuario, string apellidosUsuario, string celularUsuario, string correoUsuario, string claveUsuario, string rolUsuario)
    {
        try
        {
            lnServicio.Insertar_VUsuario_I(codigoUsuario, nombresUsuario, apellidosUsuario, celularUsuario, correoUsuario, claveUsuario, rolUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener un registro
    public EVUsuario Obtener_VUsuario_O(int codigoUsuario)
    {
        try
        {
            return lnServicio.Obtener_VUsuario_O(codigoUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Actualizar
    public void Actualizar_VUsuario_A(int codigoUsuario, string nombresUsuario, string apellidosUsuario, string celularUsuario, string correoUsuario, string claveUsuario, string rolUsuario, string estado)
    {
        try
        {
            lnServicio.Actualizar_VUsuario_A(codigoUsuario, nombresUsuario, apellidosUsuario, celularUsuario, correoUsuario, claveUsuario, rolUsuario, estado);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener todos los registros
    public List<EVUsuario> Obtener_VUsuario_O_Todo()
    {

        try
        {
            return lnServicio.Obtener_VUsuario_O_Todo();
        }
        catch (Exception)
        {
            throw;
        }

    }
    // Eliminar
    public void Eliminar_VUsuario_E(int codigoUsuario)
    {
        try
        {
            lnServicio.Eliminar_VUsuario_E(codigoUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}