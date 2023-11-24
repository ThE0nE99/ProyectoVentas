using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADVIngreso
/// </summary>
public class ADVIngreso
{
    #region Métodos públicos
    public Object Obtener_VIngreso_O_UltimoCodigoIngreso()
    {
        Object res = null;
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VIngreso_O_UltimoCodigoIngreso");
            res = bdNETVENTAS.ExecuteScalar(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
        return res;
    }
    public void Insertar_VIngreso_I(EVIngreso ingreso)
    {
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VIngreso_I");
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoIngreso", DbType.Int32, ingreso.CodigoIngreso);
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoProveedor", DbType.String, ingreso.CodigoProveedor);
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoUsuario", DbType.String, ingreso.CodigoUsuario);
            bdNETVENTAS.AddInParameter(comandoBD, "FechaIngreso", DbType.DateTime, ingreso.FechaIngreso);
            bdNETVENTAS.AddInParameter(comandoBD, "ImpuestoIngreso", DbType.String, ingreso.ImpuestoIngreso);
            bdNETVENTAS.AddInParameter(comandoBD, "TotalIngreso", DbType.String, ingreso.TotalIngreso);
            bdNETVENTAS.AddInParameter(comandoBD, "EstadoIngreso", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            bdNETVENTAS.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public DTOVIngreso Obtener_VIngreso_O(int codigoIngreso)
    {
        DTOVIngreso dtoVIngreso = new DTOVIngreso();
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VIngreso_O_CodigoIngreso");
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoIngreso", DbType.Int32, codigoIngreso);
            bdNETVENTAS.LoadDataSet(comandoBD, dtoVIngreso, "VIngreso");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoVIngreso;
    }
    public DTOVIngreso Obtener_VIngreso_O_Todo()
    {
        DTOVIngreso dtoVIngreso = new DTOVIngreso();
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VIngreso_O_Todo");
            bdNETVENTAS.LoadDataSet(comandoBD, dtoVIngreso, "VIngreso");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoVIngreso;
    }
    #endregion
}

























































