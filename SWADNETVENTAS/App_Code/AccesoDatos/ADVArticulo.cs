using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADVArticulo
/// </summary>
public class ADVArticulo
{
    #region Metodos públicos

    public Object Obtener_VArticulo_O_UltimoCodigoArticulo()
    {
        Object res = null;
        try
        {
            Database bdVENTASDB = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdVENTASDB.GetStoredProcCommand("VArticulo_O_UltimoCodigoArticulo");
            res = bdVENTASDB.ExecuteScalar(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
        return res;
    }
    public void Insertar_VArticulo_I(EVArticulo articulo)
    {
        try
        {
            Database bdVENTASDB = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdVENTASDB.GetStoredProcCommand("VArticulo_I");
            bdVENTASDB.AddInParameter(comandoBD, "CodigoArticulo", DbType.Int32, articulo.CodigoArticulo);
            bdVENTASDB.AddInParameter(comandoBD, "CategoriaArticulo", DbType.String, articulo.CategoriaArticulo);
            bdVENTASDB.AddInParameter(comandoBD, "NombreArticulo", DbType.String, articulo.NombreArticulo);
            bdVENTASDB.AddInParameter(comandoBD, "PrecioCompraArticulo", DbType.Double, articulo.PrecioCompraArticulo);
            bdVENTASDB.AddInParameter(comandoBD, "PrecioVentaArticulo", DbType.Double, articulo.PrecioVentaArticulo);
            bdVENTASDB.AddInParameter(comandoBD, "StockArticulo", DbType.Int32, articulo.StockArticulo);
            bdVENTASDB.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, SDatosPA.Auditoria_Activo);
            bdVENTASDB.AddInParameter(comandoBD, "FechaRegistro", DbType.DateTime, SDatosPA.Auditoria_FechaRegistro);
            bdVENTASDB.AddInParameter(comandoBD, "FechaActualizacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            bdVENTASDB.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public DTOVArticulo Obtener_VArticulo_O(int codigoArticulo)
    {
        DTOVArticulo dtoVArticulo = new DTOVArticulo();
        try
        {
            Database bdVENTASDB = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdVENTASDB.GetStoredProcCommand("VArticulo_O");
            bdVENTASDB.AddInParameter(comandoBD, "CodigoArticulo", DbType.Int32, codigoArticulo);
            bdVENTASDB.LoadDataSet(comandoBD, dtoVArticulo, "VArticulo");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoVArticulo;
    }
    public void Actualizar_VArticulo_A(EVArticulo articulo)
    {
        try
        {
            Database bdVENTASDB = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdVENTASDB.GetStoredProcCommand("VArticulo_A");
            bdVENTASDB.AddInParameter(comandoBD, "CodigoArticulo", DbType.Int32, articulo.CodigoArticulo);
            bdVENTASDB.AddInParameter(comandoBD, "CategoriaArticulo", DbType.String, articulo.CategoriaArticulo);
            bdVENTASDB.AddInParameter(comandoBD, "NombreArticulo", DbType.String, articulo.NombreArticulo);
            bdVENTASDB.AddInParameter(comandoBD, "PrecioCompraArticulo", DbType.Double, articulo.PrecioCompraArticulo);
            bdVENTASDB.AddInParameter(comandoBD, "PrecioVentaArticulo", DbType.Double, articulo.PrecioVentaArticulo);
            bdVENTASDB.AddInParameter(comandoBD, "StockArticulo", DbType.Int32, articulo.StockArticulo);
            bdVENTASDB.AddInParameter(comandoBD, "FechaActualizacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            bdVENTASDB.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public DTOVArticulo Obtener_VArticulo_O_Todo()
    {
        DTOVArticulo dtoVArticulo = new DTOVArticulo();
        try
        {
            Database bdVENTASDB = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdVENTASDB.GetStoredProcCommand("VArticulo_O_Todo");
            bdVENTASDB.LoadDataSet(comandoBD, dtoVArticulo, "VArticulo");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoVArticulo;
    }

    public void Eliminar_VArticulo_E(int codigoArticulo)
    {
        try
        {
            Database bdVENTASDB = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdVENTASDB.GetStoredProcCommand("VArticulo_E");
            bdVENTASDB.AddInParameter(comandoBD, "CodigoArticulo", DbType.Int32, codigoArticulo);
            bdVENTASDB.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}