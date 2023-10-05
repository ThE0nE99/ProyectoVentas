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

    #region Tabla: 1

    #endregion

    #region Tabla: VDetalleV
    public int Obtener_VDetalleVenta_O_SiguienteCodigoDetalleVenta()
    {
        try
        {
            return asNETVENTAS.Obtener_VDetalleVenta_O_SiguienteCodigoDetalleVenta();
        }
        catch (Exception)
        {
            throw;
        }
    }
   
    public List<EVDetalleVenta> Obtener_VDetalleVenta_O_CodigoVenta(int codigoVenta)
    {
        try
        {
            return asNETVENTAS.Obtener_VDetalleVenta_O_CodigoVenta(codigoVenta).ToList();
        }
        catch (Exception)
        {
            throw;
        }
    }

    #endregion

    #region Registo de la Venta
    // Insertar
    public void Insertar_Venta(EVenta eVenta, List<EDetalleVenta> lstDetalleVenta)
    {
        EVVenta eVVenta = new EVVenta();
        try
        {
            eVVenta.CodigoVenta = asNETVENTAS.Obtener_VVenta_O_SiguienteCodigoVenta();
            eVVenta.CodigoCliente = eVenta.CodigoCliente;
            eVVenta.CodigoUsuario = eVenta.CodigoUsuario;
            eVVenta.FechaHoraVenta = eVenta.FechaHoraVenta;
            eVVenta.ImpuestoVenta = eVenta.ImpuestoVenta;
            eVVenta.TotalVenta = eVenta.TotalVenta;
            eVVenta.EstadoVenta = eVenta.EstadoVenta;
            asNETVENTAS.Insertar_VVenta_I(eVVenta);
            EVDetalleVenta eVDetalleVenta = null;
            foreach (EDetalleVenta item in lstDetalleVenta)
            {
                eVDetalleVenta = new EVDetalleVenta();
                eVDetalleVenta.CodigoDetalleVenta = asNETVENTAS.Obtener_VDetalleVenta_O_SiguienteCodigoDetalleVenta();
                eVDetalleVenta.CodigoVenta = eVVenta.CodigoVenta;
                eVDetalleVenta.CodigoArticulo = item.CodigoArticulo;
                eVDetalleVenta.CantidadDetalleVenta = item.CantidadDetalleVenta;
                eVDetalleVenta.PrecioDetalleVenta = item.PrecioDetalleVenta;
                eVDetalleVenta.DescuentoDetalleVenta = item.DescuentoDetalleVenta;
                asNETVENTAS.Insertar_VDetalleVenta_I(eVDetalleVenta);
            }
            
        }
        catch (Exception)
        {
            throw;
        }
       
    }
    #endregion

    #region Tabla: VUsuario
    // Obtener último id
    public int Obtener_VUsuario_O_SiguienteCodigoUsuario()
    {
        try
        {
            return asNETVENTAS.Obtener_VUsuario_O_SiguienteCodigoUsuario();
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Insertar
    public void Insertar_VUsuario_I(int codigoUsuario, string nombresUsuario, string apellidosUsuario, string celularUsuario, string correoUsuario, string claveUsuario, string rolUsuario)
    {
        EVUsuario eVUsuario = new EVUsuario();
        try
        {
            eVUsuario.CodigoUsuario = codigoUsuario;
            eVUsuario.NombresUsuario = nombresUsuario;
            eVUsuario.ApellidosUsuario = apellidosUsuario;
            eVUsuario.CelularUsuario = celularUsuario;
            eVUsuario.CorreoUsuario = correoUsuario;
            eVUsuario.ClaveUsuario = claveUsuario;
            eVUsuario.RolUsuario = rolUsuario;
            asNETVENTAS.Insertar_VUsuario_I(eVUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener un registro
    public EVUsuario Obtener_VUsuario_O(int codigoUsuario)
    {
        try
        {
            return asNETVENTAS.Obtener_VUsuario_O(codigoUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Actualizar
    public void Actualizar_VUsuario_A(int codigoUsuario, string nombresUsuario, string apellidosUsuario, string celularUsuario, string correoUsuario, string claveUsuario, string rolUsuario, string estado)
    {
        EVUsuario eVUsuario = new EVUsuario();
        try
        {
            eVUsuario.CodigoUsuario = codigoUsuario;
            eVUsuario.NombresUsuario = nombresUsuario;
            eVUsuario.ApellidosUsuario = apellidosUsuario;
            eVUsuario.CelularUsuario = celularUsuario;
            eVUsuario.CorreoUsuario = correoUsuario;
            eVUsuario.ClaveUsuario = claveUsuario;
            eVUsuario.RolUsuario = rolUsuario;
            eVUsuario.Estado = estado;
            asNETVENTAS.Actualizar_VUsuario_A(eVUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener todos los registros
    public List<EVUsuario> Obtener_VUsuario_O_Todo()
    {
        try
        {
            return asNETVENTAS.Obtener_VUsuario_O_Todo().ToList();
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Eliminar
    public void Eliminar_VUsuario_E(int codigoUsuario)
    {
        try
        {
            asNETVENTAS.Eliminar_VUsuario_E(codigoUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region Tabla: 4

    #endregion
}