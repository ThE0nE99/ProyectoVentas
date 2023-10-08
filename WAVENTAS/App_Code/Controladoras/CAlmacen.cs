using SWLNVENTAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CAlmacen
/// </summary>
public class CAlmacen
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
    public CAlmacen()
    {
        lnServicio = new LNServicio();
    }
    #endregion

    #region Metodos Publicos
  
    // Insertar
    public void Insertar_Ingreso(EIngreso ingreso, List<EDetalleIngreso> detalleIngresos)
    {
        try
        {
            lnServicio.Insertar_Ingreso(ingreso, detalleIngresos);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}