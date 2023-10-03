using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADVProveedor
/// </summary>
public class ADVProveedor
{
    #region Métodos públicos
    public Object Obtener_VProveedor_O_UltimoCodigoProveedor()
    {
        Object res = null;
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VProveedor_O_UltimoCodigoProveedor");
            res = bdNETVENTAS.ExecuteScalar(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
        return res;
    }
    public void Insertar_VProveedor_I(EVProveedor proveedor)
    {
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VProveedor_I");
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoProveedor", DbType.Int32, proveedor.CodigoProveedor);
            bdNETVENTAS.AddInParameter(comandoBD, "TipoProveedor", DbType.String, proveedor.TipoProveedor);
            bdNETVENTAS.AddInParameter(comandoBD, "RazonSocialProveedor", DbType.String, proveedor.RazonSocialProveedor);
            bdNETVENTAS.AddInParameter(comandoBD, "DireccionProveedor", DbType.String, proveedor.DireccionProveedor);
            bdNETVENTAS.AddInParameter(comandoBD, "CelularProveedor", DbType.String, proveedor.CelularProveedor);
            bdNETVENTAS.AddInParameter(comandoBD, "CorreoProveedor", DbType.String, proveedor.CorreoProveedor);
            bdNETVENTAS.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            bdNETVENTAS.AddInParameter(comandoBD, "FechaRegistro", DbType.DateTime, SDatosPA.Auditoria_FechaRegistro);
            bdNETVENTAS.AddInParameter(comandoBD, "FechaActualizacion ", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            bdNETVENTAS.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public DTOVProveedor Obtener_VProveedor_O(int codigoProveedor)
    {
        DTOVProveedor dtoVProveedor = new DTOVProveedor();
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VProveedor_O");
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoProveedor", DbType.Int32, codigoProveedor);
            bdNETVENTAS.LoadDataSet(comandoBD, dtoVProveedor, "VProveedor");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoVProveedor;
    }
    public void Actualizar_VProveedor_A(EVProveedor proveedor)
    {
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VProveedor_A");
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoProveedor", DbType.Int32, proveedor.CodigoProveedor);
            bdNETVENTAS.AddInParameter(comandoBD, "TipoProveedor", DbType.String, proveedor.CodigoProveedor);
            bdNETVENTAS.AddInParameter(comandoBD, "RazonSocialProveedor", DbType.String, proveedor.RazonSocialProveedor);
            bdNETVENTAS.AddInParameter(comandoBD, "DireccionProveedor", DbType.String, proveedor.DireccionProveedor);
            bdNETVENTAS.AddInParameter(comandoBD, "CelularProveedor", DbType.String, proveedor.CelularProveedor);
            bdNETVENTAS.AddInParameter(comandoBD, "CorreoProveedor", DbType.String, proveedor.CorreoProveedor);
            bdNETVENTAS.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, proveedor.Estado);
            bdNETVENTAS.AddInParameter(comandoBD, "FechaActualizacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            bdNETVENTAS.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public DTOVProveedor Obtener_VProveedor_O_Todo()
    {
        DTOVProveedor dtoVProveedor = new DTOVProveedor();
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VProveedor_O_Todo");
            bdNETVENTAS.LoadDataSet(comandoBD, dtoVProveedor, "VProveedor");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoVProveedor;
    }
    public void Eliminar_VProveedor_E(int codigoProveedor)
    {
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VProveedor_E");
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoProveedor", DbType.Int32, codigoProveedor);
            bdNETVENTAS.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }

    #endregion
}