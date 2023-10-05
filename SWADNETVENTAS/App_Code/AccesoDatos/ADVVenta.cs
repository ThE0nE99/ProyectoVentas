using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADVVenta
/// </summary>
public class ADVVenta
{
    #region Metodos publicos
    // Obtener último id
    public Object Obtener_VVenta_O_UltimoCodigoVenta()
    {
        Object res = null;
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VVenta_O_UltimoCodigoVenta");
            res = bdNETVENTAS.ExecuteScalar(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
        return res;
    }
    // Insertar
    public void Insertar_VVenta_I(EVVenta venta)
    {
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VVenta_I");
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoVenta", DbType.Int32, venta.CodigoVenta);
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoCliente", DbType.Int32, venta.CodigoCliente);
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoUsuario", DbType.Int32, venta.CodigoUsuario);
            bdNETVENTAS.AddInParameter(comandoBD, "FechaHoraVenta", DbType.DateTime, venta.FechaHoraVenta);
            bdNETVENTAS.AddInParameter(comandoBD, "ImpuestoVenta", DbType.Double, venta.ImpuestoVenta);
            bdNETVENTAS.AddInParameter(comandoBD, "TotalVenta", DbType.Double, venta.TotalVenta);
            bdNETVENTAS.AddInParameter(comandoBD, "EstadoVenta", DbType.String, venta.EstadoVenta);
            bdNETVENTAS.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener una venta
    public DTOVVenta Obtener_VVenta_O_CodigoVenta(int codigoVenta)
    {
        DTOVVenta dtoVUsuario = new DTOVVenta();
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VVenta_O_CodigoVenta");
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoVenta", DbType.Int32, codigoVenta);
            bdNETVENTAS.LoadDataSet(comandoBD, dtoVUsuario, "VVenta");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoVUsuario;
    }
    #endregion
}