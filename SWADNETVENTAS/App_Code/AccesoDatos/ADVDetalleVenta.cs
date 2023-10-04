using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADVDetalleVenta
/// </summary>
public class ADVDetalleVenta
{
    public Object Obtener_VDetalleVenta_O_UltimoCodigoDetalleVenta()
    {
        Object res = null;
        try
        {
            Database bdVENTASDB = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdVENTASDB.GetStoredProcCommand("VDetalleVenta_O_UltimoCodigoDetalleVenta");
            res = bdVENTASDB.ExecuteScalar(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
        return res;
    }
    public void Insertar_VDetalleVenta_I(EVDetalleVenta detalleVenta)
    {
        try
        {
            Database bdVENTASDB = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdVENTASDB.GetStoredProcCommand("VDetalleVenta_I");
            bdVENTASDB.AddInParameter(comandoBD, "CodigoDetalleVenta", DbType.Int32, detalleVenta.CodigoDetalleVenta);
            bdVENTASDB.AddInParameter(comandoBD, "CodigoVenta", DbType.Int32, detalleVenta.CodigoVenta);
            bdVENTASDB.AddInParameter(comandoBD, "CodigoArticulo", DbType.Int32, detalleVenta.CodigoArticulo);
            bdVENTASDB.AddInParameter(comandoBD, "CantidadDetalleVenta", DbType.Int32, detalleVenta.CantidadDetalleVenta);
            bdVENTASDB.AddInParameter(comandoBD, "PrecioDetalleVenta", DbType.Double, detalleVenta.PrecioDetalleVenta);
            bdVENTASDB.AddInParameter(comandoBD, "DescuentoDetalleVenta", DbType.Double, detalleVenta.DescuentoDetalleVenta);
            bdVENTASDB.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public DTOVDetalleVenta Obtener_VDetalleVenta_O_CodigoVenta(int codigoVenta)
    {
        DTOVDetalleVenta dtoVDetalleVenta = new DTOVDetalleVenta();
        try
        {
            Database bdVENTASDB = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdVENTASDB.GetStoredProcCommand("VDetalleVenta_O_CodigoVenta");
            bdVENTASDB.AddInParameter(comandoBD, "CodigoVenta", DbType.Int32, codigoVenta);
            bdVENTASDB.LoadDataSet(comandoBD, dtoVDetalleVenta, "VDetalleVenta");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoVDetalleVenta;
    }
}