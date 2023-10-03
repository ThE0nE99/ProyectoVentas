using SWADNETVENTAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CVENTAS
/// </summary>
public class CVENTAS
{
    #region Atributos
    private ASNETVENTAS asNETVENTAS;
    #endregion

    #region Constructor
    public CVENTAS()
    {
        asNETVENTAS = new ASNETVENTAS();
    }
    #endregion

    #region Tabla: 1

    #endregion

    #region Tabla: 2

    #endregion

    #region Tabla: VUsuario
    // Obtener último id
    public int Obtener_VUsuario_O_SiguienteCodigoUsuario()
    {
        try
        {
            return asNETVENTAS.Obtener_VUsuario_O_SiguienteCodigoUsuario();
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Insertar
    public void Insertar_VUsuario_I(int codigoUsuario, string nombresUsuario, string apellidosUsuario, string celularUsuario, string correoUsuario, string claveUsuario, string rolUsuario)
    {
        EVUsuario eVUsuario = new EVUsuario();
        try
        {
            eVUsuario.CodigoUsuario = codigoUsuario;
            eVUsuario.NombresUsuario = nombresUsuario;
            eVUsuario.ApellidosUsuario = apellidosUsuario;
            eVUsuario.CelularUsuario = celularUsuario;
            eVUsuario.CorreoUsuario = correoUsuario;
            eVUsuario.ClaveUsuario = claveUsuario;
            eVUsuario.RolUsuario = rolUsuario;
            asNETVENTAS.Insertar_VUsuario_I(eVUsuario);
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
            return asNETVENTAS.Obtener_VUsuario_O(codigoUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Actualizar
    public void Actualizar_VUsuario_A(int codigoUsuario, string nombresUsuario, string apellidosUsuario, string celularUsuario, string correoUsuario, string claveUsuario, string rolUsuario, string estado)
    {
        EVUsuario eVUsuario = new EVUsuario();
        try
        {
            eVUsuario.CodigoUsuario = codigoUsuario;
            eVUsuario.NombresUsuario = nombresUsuario;
            eVUsuario.ApellidosUsuario = apellidosUsuario;
            eVUsuario.CelularUsuario = celularUsuario;
            eVUsuario.CorreoUsuario = correoUsuario;
            eVUsuario.ClaveUsuario = claveUsuario;
            eVUsuario.RolUsuario = rolUsuario;
            eVUsuario.Estado = estado;
            asNETVENTAS.Actualizar_VUsuario_A(eVUsuario);
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
            return asNETVENTAS.Obtener_VUsuario_O_Todo().ToList();
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
            asNETVENTAS.Eliminar_VUsuario_E(codigoUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region Tabla: 4

    #endregion
}