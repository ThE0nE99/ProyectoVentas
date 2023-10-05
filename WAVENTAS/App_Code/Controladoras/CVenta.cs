using SWLNVENTAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CVenta
/// </summary>
public class CVenta
{
    #region Atributos
    private LNServicio lnServicio;
    #endregion

    #region Propiedades
    public string NombreClase
    {
        get { return GetType().Name; }
    }
    #endregion

    #region Constructor
    public CVenta()
    {
        lnServicio = new LNServicio();
    }
    #endregion

    #region Metodos Publicos

    #region Registo de la Venta
    // Insertar
    public void Insertar_Venta(EVenta eVenta, List<EDetalleVenta> lstDetalleVenta)
    {
        try
        {
            lnServicio.Insertar_Venta(eVenta, lstDetalleVenta);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #endregion
}