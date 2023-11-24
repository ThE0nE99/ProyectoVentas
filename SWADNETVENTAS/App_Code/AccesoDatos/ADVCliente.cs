using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADVCliente
/// </summary>
public class ADVCliente
{
    #region Metodos públicos
    public Object Obtener_VCliente_O_UltimoCodigoCliente()
    {
        Object res = null;
        try
        {
            Database bdVENTASDB = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdVENTASDB.GetStoredProcCommand("VCliente_O_UltimoCodigoCliente");
            res = bdVENTASDB.ExecuteScalar(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
        return res;
    }
    public void Insertar_VCliente_I(EVCliente cliente)
    {
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VCliente_I");
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoCliente", DbType.Int32, cliente.CodigoCliente);
            bdNETVENTAS.AddInParameter(comandoBD, "RazonSocialCliente", DbType.String, cliente.RazonSocialCliente);
            bdNETVENTAS.AddInParameter(comandoBD, "CiONitCliente", DbType.String, cliente.CiONitCliente);
            bdNETVENTAS.AddInParameter(comandoBD, "TipoCliente", DbType.StringFixedLength, cliente.TipoCliente);
            bdNETVENTAS.AddInParameter(comandoBD, "DirecionCliente", DbType.String, cliente.DirecionCliente);
            bdNETVENTAS.AddInParameter(comandoBD, "CelularCliente", DbType.String, cliente.CelularCliente);
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
    public DTOVCliente Obtener_VCliente_O(int codigoCliente)
    {
        DTOVCliente dtoVCliente = new DTOVCliente();
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VCliente_O");
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoCliente", DbType.Int32, codigoCliente);
            bdNETVENTAS.LoadDataSet(comandoBD, dtoVCliente, "VCliente");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoVCliente;
    }
    public void Actualizar_VCliente_A(EVCliente cliente)
    {
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VCliente_A");
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoCliente", DbType.Int32, cliente.CodigoCliente);
            bdNETVENTAS.AddInParameter(comandoBD, "RazonSocialCliente", DbType.String, cliente.RazonSocialCliente);
            bdNETVENTAS.AddInParameter(comandoBD, "CiONitCliente", DbType.String, cliente.CiONitCliente);
            bdNETVENTAS.AddInParameter(comandoBD, "TipoCliente", DbType.StringFixedLength, cliente.TipoCliente);
            bdNETVENTAS.AddInParameter(comandoBD, "DirecionCliente", DbType.String, cliente.DirecionCliente);
            bdNETVENTAS.AddInParameter(comandoBD, "CelularCliente", DbType.String, cliente.CelularCliente);
            bdNETVENTAS.AddInParameter(comandoBD, "Estado", DbType.StringFixedLength, cliente.Estado);
            bdNETVENTAS.AddInParameter(comandoBD, "FechaActualizacion", DbType.DateTime, SDatosPA.Auditoria_FechaModificacion);
            bdNETVENTAS.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public DTOVCliente Obtener_VClientes_O_Todo()
    {
        DTOVCliente dtoVCliente = new DTOVCliente();
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VClientes_O_Todos");
            bdNETVENTAS.LoadDataSet(comandoBD, dtoVCliente, "VCliente");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoVCliente;
    }
    public void Eliminar_VCliente_E(int codigoCliente)
    {
        try
        {
            Database bdNETVENTAS = SBaseDatos.BDNETVENTAS;
            DbCommand comandoBD = bdNETVENTAS.GetStoredProcCommand("VCliente_E");
            bdNETVENTAS.AddInParameter(comandoBD, "CodigoCliente", DbType.Int32, codigoCliente);
            bdNETVENTAS.ExecuteNonQuery(comandoBD);
        }
        catch (Exception)
        {
            throw;
        }
    }

    #endregion

}