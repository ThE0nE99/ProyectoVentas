using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using Microsoft.Win32;

/// <summary>
/// Descripción breve de CVUsuario
/// </summary>
public class CVUsuario
{

    #region Atributos
    private ADVUsuario adVUsuario;
    #endregion

    #region Constructor
    public CVUsuario()
    {
        adVUsuario = new ADVUsuario();
    }
    #endregion

    #region Métodos públicos
    // Obtener último id
    public int Obtener_VUsuario_O_SiguienteCodigoUsuario()
    {
        Object res = adVUsuario.Obtener_VUsuario_O_UltimoCodigoUsuario();
        if (res.ToString().IsNullOrEmpty())
            return 1;
        else
            return (int)res + 1;
    }
    // Insertar
    public void Insertar_VUsuario_I(EVUsuario usuario)
    {
        adVUsuario.Insertar_VUsuario_I(usuario);
    }
    // Obtener un registro
    public EVUsuario Obtener_VUsuario_O(int codigoUsuario)
    {
        EVUsuario eVUsuario = null;
        DTOVUsuario dtoVUsuario = adVUsuario.Obtener_VUsuario_O(codigoUsuario);
        foreach (DTOVUsuario.VUsuarioRow drVUsuario in dtoVUsuario.VUsuario.Rows)
        {
            eVUsuario.CodigoUsuario = drVUsuario.CodigoUsuario;
            eVUsuario.NombresUsuario = drVUsuario.NombresUsuario;
            eVUsuario.ApellidosUsuario = drVUsuario.ApellidosUsuario;
            eVUsuario.CelularUsuario = drVUsuario.CelularUsuario;
            eVUsuario.CorreoUsuario = drVUsuario.CorreoUsuario;
            eVUsuario.ClaveUsuario = drVUsuario.ClaveUsuario;
            eVUsuario.RolUsuario = drVUsuario.RolUsuario;
            eVUsuario.Estado = drVUsuario.Estado;
            eVUsuario.FechaRegistro = drVUsuario.FechaRegistro;
            eVUsuario.FechaActulizacion = drVUsuario.FechaActualizacion;
        }
        return eVUsuario;
    }
    // Actualizar
    public void Actualizar_VUsuario_A(EVUsuario usuario)
    {
        adVUsuario.Actualizar_VUsuario_A(usuario);
    }
    // Obtener todos los registros
    public List<EVUsuario> Obtener_VUsuario_O_Todo()
    {
        EVUsuario eVUsuario = null;
        List<EVUsuario> lstEVUsuario = new List<EVUsuario>();
        DTOVUsuario dtoVUsuario = adVUsuario.Obtener_VUsuario_O_Todo();
        foreach (DTOVUsuario.VUsuarioRow drVUsuario in dtoVUsuario.VUsuario.Rows)
        {
            eVUsuario = new EVUsuario();
            eVUsuario.CodigoUsuario = drVUsuario.CodigoUsuario;
            eVUsuario.NombresUsuario = drVUsuario.NombresUsuario;
            eVUsuario.ApellidosUsuario = drVUsuario.ApellidosUsuario;
            eVUsuario.CelularUsuario = drVUsuario.CelularUsuario;
            eVUsuario.CorreoUsuario = drVUsuario.CorreoUsuario;
            eVUsuario.ClaveUsuario = drVUsuario.ClaveUsuario;
            eVUsuario.RolUsuario = drVUsuario.RolUsuario;
            eVUsuario.Estado = drVUsuario.Estado;
            eVUsuario.FechaRegistro = drVUsuario.FechaRegistro;
            eVUsuario.FechaActulizacion = drVUsuario.FechaActualizacion;
            lstEVUsuario.Add(eVUsuario);
        }
        return lstEVUsuario;
    }
    // Eliminar
    public void Eliminar_VUsuario_E(int codigoUsuario)
    {
        adVUsuario.Eliminar_VUsuario_E(codigoUsuario);
    }
    #endregion
}