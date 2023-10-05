using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SWADNETVENTAS;

/// <summary>
/// Descripción breve de ASNETVENTAS
/// </summary>
public class ASNETVENTAS
{
    #region Atributos
    private SWADNETVENTASClient swadNETVENTAS;
    #endregion

    #region Constructor
    public ASNETVENTAS()
    {
        swadNETVENTAS = new SWADNETVENTASClient();
    }
    #endregion

    #region Tabla: 1

    #endregion
    #region Tabla: VDetalleVenta
    public int Obtener_VDetalleVenta_O_SiguienteCodigoDetalleVenta()
    {
        int respuesta = 0;
        try
        {
            respuesta = swadNETVENTAS.Obtener_VDetalleVenta_O_SiguienteCodigoDetalleVenta();
            return respuesta;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Insertar_VDetalleVenta_I(EVDetalleVenta eVDetalleVenta)
    {
        try
        {
            swadNETVENTAS.Insertar_VDetalleVenta_I(eVDetalleVenta);
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
            return swadNETVENTAS.Obtener_VDetalleVenta_O_CodigoVenta(codigoVenta).ToList();
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region Tabla: VVenta
    // Obtener último id Venta
    public int Obtener_VVenta_O_SiguienteCodigoVenta()
    {
        int res = 0;
        try
        {
            res = swadNETVENTAS.Obtener_VVenta_O_SiguienteCodigoVenta();
            return res;
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Insertar
    public void Insertar_VVenta_I(EVVenta venta)
    {
        try
        {
            swadNETVENTAS.Insertar_VVenta_I(venta);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener un registro
    /*
    public EVVenta Obtener_VVenta_O(int codigoVenta)
    {
        EVVenta eVVenta = new EVVenta();
        try
        {
            eVVenta = swadNETVENTAS.Obtener_VVenta_O(codigoVenta);
            return eVVenta;
        }
        catch (Exception)
        {
            throw;
        }
    }*/
    /*
    // Actualizar
    public void Actualizar_VUsuario_A(EVUsuario usuario)
    {
        try
        {
            swadNETVENTAS.Actualizar_VUsuario_A(usuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener todos los registros
    public List<EVUsuario> Obtener_VUsuario_O_Todo()
    {
        List<EVUsuario> lstVUsuario = new List<EVUsuario>();
        try
        {
            lstVUsuario = swadNETVENTAS.Obtener_VUsuario_O_Todo().ToList();
            return lstVUsuario;
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
            swadNETVENTAS.Eliminar_VUsuario_E(codigoUsuario);
        }
        catch (Exception)
        {
            throw;
        }

    }*/
    #endregion

    #region Tabla: VUsuario
    // Obtener último id
    public int Obtener_VUsuario_O_SiguienteCodigoUsuario()
    {
        int res = 0;
        try
        {
            res = swadNETVENTAS.Obtener_VUsuario_O_SiguienteCodigoUsuario();
            return res;
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Insertar
    public void Insertar_VUsuario_I(EVUsuario usuario)
    {
        try
        {
            swadNETVENTAS.Insertar_VUsuario_I(usuario);
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
            eVUsuario = swadNETVENTAS.Obtener_VUsuario_O(codigoUsuario);
            return eVUsuario;
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Actualizar
    public void Actualizar_VUsuario_A(EVUsuario usuario)
    {
        try
        {
            swadNETVENTAS.Actualizar_VUsuario_A(usuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener todos los registros
    public List<EVUsuario> Obtener_VUsuario_O_Todo()
    {
        List<EVUsuario> lstVUsuario = new List<EVUsuario>();
        try
        {
            lstVUsuario = swadNETVENTAS.Obtener_VUsuario_O_Todo().ToList();
            return lstVUsuario;
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
            swadNETVENTAS.Eliminar_VUsuario_E(codigoUsuario);
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