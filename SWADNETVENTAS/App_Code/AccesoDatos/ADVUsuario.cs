using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADVUsuario
/// </summary>
public class ADVUsuario
{
    #region Metodos publicos
    // Obtener último id
    public Object Obtener_VUsuario_O_UltimoCodigoUsuario()
    {
        Object res = null;
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VUsuario_O_UltimoCodigoUsuario");
            res = bdNETVENTAS.ExecuteScalar(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
        return res;
    }
    // Insertar
    public void Insertar_VUsuario_I(EVUsuario usuario)
    {
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VUsuario_I");
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoUsuario", DbType.Int32, usuario.CodigoUsuario);
            bdNETVENTAS.AddInParameter(comandoBD, "NombresUsuario", DbType.String, usuario.NombresUsuario);
            bdNETVENTAS.AddInParameter(comandoBD, "ApellidosUsuario", DbType.String, usuario.ApellidosUsuario);
            bdNETVENTAS.AddInParameter(comandoBD, "CelularUsuario", DbType.String, usuario.CelularUsuario);
            bdNETVENTAS.AddInParameter(comandoBD, "CorreoUsuario", DbType.String, usuario.CorreoUsuario);
            bdNETVENTAS.AddInParameter(comandoBD, "ClaveUsuario", DbType.String, usuario.ClaveUsuario);
            bdNETVENTAS.AddInParameter(comandoBD, "RolUsuario", DbType.String, usuario.RolUsuario);
            bdNETVENTAS.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            bdNETVENTAS.AddInParameter(comandoBD, "FechaRegistro", DbType.DateTime, SDatosPA.Auditoria_FechaRegistro);
            bdNETVENTAS.AddInParameter(comandoBD, "FechaActualizacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            bdNETVENTAS.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener un registro
    public DTOVUsuario Obtener_VUsuario_O(int codigoUsuario)
    {
        DTOVUsuario dtoVUsuario = new DTOVUsuario();
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VUsuario_O");
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoUsuario", DbType.Int32, codigoUsuario);
            bdNETVENTAS.LoadDataSet(comandoBD, dtoVUsuario, "VUsuario");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoVUsuario;
    }
    // Actualizar
    public void Actualizar_VUsuario_A(EVUsuario usuario)
    {
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VUsuario_A");
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoUsuario", DbType.Int32, usuario.CodigoUsuario);
            bdNETVENTAS.AddInParameter(comandoBD, "NombresUsuario", DbType.String, usuario.NombresUsuario);
            bdNETVENTAS.AddInParameter(comandoBD, "ApellidosUsuario", DbType.String, usuario.ApellidosUsuario);
            bdNETVENTAS.AddInParameter(comandoBD, "CelularUsuario", DbType.String, usuario.CelularUsuario);
            bdNETVENTAS.AddInParameter(comandoBD, "CorreoUsuario", DbType.String, usuario.CorreoUsuario);
            bdNETVENTAS.AddInParameter(comandoBD, "ClaveUsuario", DbType.String, usuario.ClaveUsuario);
            bdNETVENTAS.AddInParameter(comandoBD, "RolUsuario", DbType.String, usuario.RolUsuario);
            bdNETVENTAS.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, usuario.Estado);
            bdNETVENTAS.AddInParameter(comandoBD, "FechaActualizacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            bdNETVENTAS.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Eliminacion logica aqui

    // Obtener todos los registros
    public DTOVUsuario Obtener_VUsuario_O_Todo()
    {
        DTOVUsuario dtoVUsuario = new DTOVUsuario();
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VUsuario_O_Todo");
            bdNETVENTAS.LoadDataSet(comandoBD, dtoVUsuario, "VUsuario");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoVUsuario;
    }
    // Eliminar
    public void Eliminar_VUsuario_E(int codigoUsuario)
    {
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VUsuario_E");
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoUsuario", DbType.Int32, codigoUsuario);
            bdNETVENTAS.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }

    #endregion
}