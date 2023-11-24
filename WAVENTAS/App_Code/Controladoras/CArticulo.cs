using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SWLNVENTAS;

/// <summary>
/// Descripción breve de CArticulo
/// </summary>
public class CArticulo
{
    #region Atributos

    private LNServicio lNServicio;

    #endregion

    #region Propiedades

    public string NombreClase
    {
        get { return GetType().Name; }
    }

    #endregion

    #region Constructor

    public CArticulo()
    {
        lNServicio = new LNServicio();
    }

    #endregion

    #region Metodos Publicos

    #region Tabla: VArticulos
    public int Obtener_VArticulo_O_SiguienteCodigoArticulo()
    {
        try
        {
            return lNServicio.Obtener_VArticulo_O_SiguienteCodigoArticulo();

        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Insertar_VArticulo_I(int codigoArticulo, string categoriaArticulo, string nombreArticulo, double precioCompraArticulo, double precioVentaArticulo, int stockArticulo)
    {
        try
        {
            lNServicio.Insertar_VArticulo_I(codigoArticulo, categoriaArticulo, nombreArticulo, precioCompraArticulo, precioVentaArticulo, stockArticulo);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public EVArticulo Obtener_VArticulo_O(int codigoArticulo)
    {
        EVArticulo eVArticulo = new EVArticulo();
        try
        {
            eVArticulo = lNServicio.Obtener_VArticulo_O(codigoArticulo);
        }
        catch (Exception)
        {
            throw;
        }
        return eVArticulo;
    }

    public void Actualizar_VArticulo_A(int codigoArticulo, string categoriaArticulo, string nombreArticulo, double precioCompraArticulo, double precioVentaArticulo, int stockArticulo)
    {
        try
        {
            lNServicio.Actualizar_VArticulo_A(codigoArticulo, categoriaArticulo, nombreArticulo, precioCompraArticulo, precioVentaArticulo, stockArticulo);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVArticulo> Obtener_GRol_O_Todo()
    {
        List<EVArticulo> lstEVArticulo = new List<EVArticulo>();
        try
        {
            lstEVArticulo = lNServicio.Obtener_VArticulo_O_Todo().ToList();
        }
        catch (Exception)
        {
            throw;
        }
        return lstEVArticulo;
    }
    public void Eliminar_VArticulo_E(int codigoArticulo)
    {
        try
        {
            lNServicio.Eliminar_VArticulo_E(codigoArticulo);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #endregion
}