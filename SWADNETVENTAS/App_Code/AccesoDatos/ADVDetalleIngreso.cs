using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADVDetalleIngreso
/// </summary>
public class ADVDetalleIngreso
{
    #region Metodos públicos
    public Object Obtener_VDetalleIngreso_O_UltimoCodigoDetalleIngreso()
    {
        Object res = null;
        try
        {
            Database bdVENTASDB = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdVENTASDB.GetStoredProcCommand("VDetalleIngreso_O_UltimoCodigoDetalleIngreso");
            res = bdVENTASDB.ExecuteScalar(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
        return res;
    }
    public void Insertar_VDetalleIngreso_I(EVDetalleIngreso detalle)
    {
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VDetalleIngreso_I");
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoDetalleIngreso", DbType.Int32, detalle.CodigoDetalleIngreso);
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoIngreso", DbType.Int32, detalle.CodigoDetalleIngreso);
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoArticulo", DbType.Int32, detalle.CodigoArticulo);
            bdNETVENTAS.AddInParameter(comandoBD, "CantidadIngreso", DbType.Int32, detalle.CantidadIngreso);
            bdNETVENTAS.AddInParameter(comandoBD, "PrecioIngreso", DbType.Decimal, detalle.PrecioIngreso);
            bdNETVENTAS.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public DTOVDetalleIngreso Obtener_VDetalleIngreso_OCodigoDetalleIngreso(int codigoDetalle)
    {
        DTOVDetalleIngreso dtoVDetalle = new DTOVDetalleIngreso();
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VDetalleIngreso_OCodigoDetalleIngreso");
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoDetalleIngreso", DbType.Int32, codigoDetalle);
            bdNETVENTAS.LoadDataSet(comandoBD, dtoVDetalle, "VDetalleIngreso");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoVDetalle;
    }
    #endregion
}
