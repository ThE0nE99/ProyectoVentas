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

    #region VArticulo
    public int Obtener_VArticulo_O_SiguienteCodigoArticulo()
    {
        int resultado = 0;
        try
        {
            using (SWLNVENTASClient clienteSWLNVENTAS = new SWLNVENTASClient())
            {
                resultado = clienteSWLNVENTAS.Obtener_VArticulo_O_SiguienteCodigoArticulo();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return resultado;
    }
    public void Insertar_VArticulo_I(int codigoArticulo, string categoriaArticulo, string nombreArticulo, double precioCompraArticulo, double precioVentaArticulo, int stockArticulo)
    {
        try
        {
            using (SWLNVENTASClient clienteSWLNVENTAS = new SWLNVENTASClient())
            {
                clienteSWLNVENTAS.Insertar_VArticulo_I(codigoArticulo, categoriaArticulo, nombreArticulo, precioCompraArticulo, precioVentaArticulo, stockArticulo);
            }
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
            using (SWLNVENTASClient clienteSWLNVENTAS = new SWLNVENTASClient())
            {
                eVArticulo = clienteSWLNVENTAS.Obtener_VArticulo_O(codigoArticulo);
            }
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
            using (SWLNVENTASClient clienteSWLNVENTAS = new SWLNVENTASClient())
            {
                clienteSWLNVENTAS.Actualizar_VArticulo_A(codigoArticulo, categoriaArticulo, nombreArticulo, precioCompraArticulo, precioVentaArticulo, stockArticulo);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public List<EVArticulo> Obtener_VArticulo_O_Todo()
    {
        List<EVArticulo> lstEVArticulo = new List<EVArticulo>();
        try
        {
            using (SWLNVENTASClient clienteSWLNVENTAS = new SWLNVENTASClient())
            {
                lstEVArticulo = clienteSWLNVENTAS.Obtener_VArticulo_O_Todo().ToList();
            }
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
            using (SWLNVENTASClient clienteSWLNVENTAS = new SWLNVENTASClient())
            {
                clienteSWLNVENTAS.Eliminar_VArticulo_E(codigoArticulo);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region Tabla: 2

    #endregion

    #region Tabla: 3

    #endregion

    #region Tabla: 4

    #endregion

    #endregion
}