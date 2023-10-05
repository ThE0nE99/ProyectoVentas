using SWLNVENTAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de LNServicio
/// </summary>
public class LNServicio
{
    #region Propiedades
    public string NombreClase
    {
        get { return GetType().Name; }
    }
    #endregion

    #region Constructor
    public LNServicio()
    {
    }
    #endregion

    #region Métodos públicos

    #region Tabla: 1

    #endregion

    #region Tabla: 2

    #endregion

    #region Tabla: VVenta
    
    // Insertar
    public void Insertar_Venta(EVenta eVenta, List<EDetalleVenta> lstDetalleVenta)
    {
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                // Convierte la lista en un arreglo
                //EDetalleVenta[] arregloDetalleVenta = lstDetalleVenta.ToArray();
                swlnVENTAS.Insertar_Venta(eVenta, lstDetalleVenta.ToArray());
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener un registro
    /*
    public EVVenta Obtener_VVenta_O(int codigoUsuario)
    {
        EVVenta eVVenta = new EVVenta();
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                eVVenta = swlnVENTAS.Obtener_VVenta_O(codigoUsuario);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eVVenta;
    }*/
    #endregion

    #region Tabla: VUsuario
    // Obtener último id
    public int Obtener_VUsuario_O_SiguienteCodigoUsuario()
    {
        int resultado = 0;
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                resultado = swlnVENTAS.Obtener_VUsuario_O_SiguienteCodigoUsuario();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return resultado;
    }
    // Insertar
    public void Insertar_VUsuario_I(int codigoUsuario, string nombresUsuario, string apellidosUsuario, string celularUsuario, string correoUsuario, string claveUsuario, string rolUsuario)
    {
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                swlnVENTAS.Insertar_VUsuario_I(codigoUsuario, nombresUsuario, apellidosUsuario, celularUsuario, correoUsuario, claveUsuario, rolUsuario);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener un registro
    public EVUsuario Obtener_VUsuario_O(int codigoUsuario)
    {
        EVUsuario eVUsuario = new EVUsuario();
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                eVUsuario = swlnVENTAS.Obtener_VUsuario_O(codigoUsuario);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eVUsuario;
    }
    // Actualizar
    public void Actualizar_VUsuario_A(int codigoUsuario, string nombresUsuario, string apellidosUsuario, string celularUsuario, string correoUsuario, string claveUsuario, string rolUsuario, string estado)
    {
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                swlnVENTAS.Actualizar_VUsuario_A(codigoUsuario, nombresUsuario, apellidosUsuario, celularUsuario, correoUsuario, claveUsuario, rolUsuario, estado);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener todos los registros
    public List<EVUsuario> Obtener_VUsuario_O_Todo()
    {
        List<EVUsuario> lstEVUsuario = new List<EVUsuario>();
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                lstEVUsuario = swlnVENTAS.Obtener_VUsuario_O_Todo().ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEVUsuario;
    }
    // Eliminar
    public void Eliminar_VUsuario_E(int codigoUsuario)
    {
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                swlnVENTAS.Eliminar_VUsuario_E(codigoUsuario);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region Tabla: 4

    #endregion

    #endregion
}