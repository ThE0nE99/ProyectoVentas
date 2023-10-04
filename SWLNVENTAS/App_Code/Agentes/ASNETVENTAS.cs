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


    #region Tabla: VArticulo
    public int Obtener_VArticulo_O_SiguienteCodigoArticulo()
    {
        int respuesta = 0;
        try
        {
            respuesta = swadNETVENTAS.Obtener_VArticulo_O_SiguienteCodigoArticulo();
            return respuesta;
        }
        catch (Exception)
        {
            throw;
        }

    }
    public void Insertar_VArticulo_I(EVArticulo eVArticulo)
    {
        try
        {
            swadNETVENTAS.Insertar_VArticulo_I(eVArticulo);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EVArticulo Obtener_VArticulo_O(int codigoProyecto)
    {
        EVArticulo eVArticulo = new EVArticulo();
        try
        {
            eVArticulo = swadNETVENTAS.Obtener_VArticulo_O(codigoProyecto);
            return eVArticulo;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_VArticulo_A(EVArticulo eVArticulo)
    {
        try
        {
            swadNETVENTAS.Actualizar_VArticulo_A(eVArticulo);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVArticulo> Obtener_VArticulo_O_Todo()
    {
        try
        {
            return swadNETVENTAS.Obtener_VArticulo_O_Todo().ToList();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Eliminar_VArticulo_E(int codigoProyecto)
    {
        try
        {
            swadNETVENTAS.Eliminar_VArticulo_E(codigoProyecto);
        }
        catch (Exception)
        {
            throw;
        }
    }
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

    #region Tabla: 3

    #endregion

    #region Tabla: 4

    #endregion
}