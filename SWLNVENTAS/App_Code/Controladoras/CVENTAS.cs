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

    #region Tabla: EVCliente
    public int Obtener_VCliente_O_SiguienteCodigoCliente()
    {

        try
        {
            return asNETVENTAS.Obtener_VCliente_O_SiguienteCodigoCliente();
        }
        catch (Exception)
        {
            throw;
        }
    }



    public void Insertar_VCliente_I(int codigoCliente, string razonSocialCliente, string ciONitCliente, string tipoCliente, string direcionCliente, string celularCliente)
    {
        EVCliente eVCliente = new EVCliente();
        try
        {
            eVCliente.CodigoCliente = codigoCliente;
            eVCliente.RazonSocialCliente = razonSocialCliente;
            eVCliente.CiONitCliente = ciONitCliente;
            eVCliente.TipoCliente = tipoCliente;
            eVCliente.DirecionCliente = direcionCliente;
            eVCliente.CelularCliente = celularCliente;
            asNETVENTAS.Insertar_VCliente_I(eVCliente);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EVCliente Obtener_VCliente_O(int codigoCliente)
    {
        try
        {
            return asNETVENTAS.Obtener_VCliente_O(codigoCliente);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_VCliente_A(int codigoCliente, string razonSocialCliente, string ciONitCliente, string tipoCliente, string direcionCliente, string celularCliente, string estado)
    {
        EVCliente eVCliente = new EVCliente();
        try
        {
            eVCliente.CodigoCliente = codigoCliente;
            eVCliente.RazonSocialCliente = razonSocialCliente;
            eVCliente.CiONitCliente = ciONitCliente;
            eVCliente.TipoCliente = tipoCliente;
            eVCliente.DirecionCliente = direcionCliente;
            eVCliente.CelularCliente = celularCliente;
            eVCliente.Estado = estado;
            asNETVENTAS.Actualizar_VCliente_A(eVCliente);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVCliente> Obtener_VClientes_O_Todo()
    {

        try
        {
            return asNETVENTAS.Obtener_VClientes_O_Todo().ToList();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Eliminar_VCliente_E(int codigoCliente)
    {
        try
        {
            asNETVENTAS.Eliminar_VCliente_E(codigoCliente);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion


    #region Registro Ingreso

    public void Insertar_Ingreso(EIngreso ingreso, List<EDetalleIngreso> detalleIngresos)
    {
        try
        {
            EVIngreso eVIngreso = new EVIngreso();
            eVIngreso.CodigoIngreso = asNETVENTAS.Obtener_VIngreso_O_SiguienteCodigoIngreso();
            eVIngreso.CodigoProveedor = ingreso.CodigoProveedor;
            eVIngreso.CodigoUsuario = ingreso.CodigoUsuario;
            eVIngreso.FechaIngreso = ingreso.FechaIngreso;
            eVIngreso.ImpuestoIngreso = ingreso.ImpuestoIngreso;
            eVIngreso.TotalIngreso = ingreso.TotalIngreso;
            eVIngreso.EstadoIngreso = ingreso.EstadoIngreso;
            asNETVENTAS.Insertar_VIngreso_I(eVIngreso);
            EVDetalleIngreso eVDetalleIngreso = null;
            foreach (EDetalleIngreso item in detalleIngresos)
            {
                eVDetalleIngreso = new EVDetalleIngreso();
                eVDetalleIngreso.CodigoDetalleIngreso = asNETVENTAS.Obtener_VDetalleIngreso_O_SiguienteCodigoDetalleIngreso();
                eVDetalleIngreso.CodigoIngreso = eVIngreso.CodigoIngreso;
                eVDetalleIngreso.CodigoArticulo = item.CodigoArticulo;
                eVDetalleIngreso.CantidadIngreso = item.CantidadIngreso;
                eVDetalleIngreso.PrecioIngreso = item.PrecioIngreso;
                asNETVENTAS.Insertar_VDetalleIngreso_I(eVDetalleIngreso);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    #endregion

    #region Tabla: 3

    #endregion

    #region Tabla: 4

    #endregion
}