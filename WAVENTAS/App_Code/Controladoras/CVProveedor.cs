using SWLNVENTAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CVProveedor
/// </summary>
public class CVProveedor
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
    public CVProveedor()
    {
        lnServicio = new LNServicio();
    }
    #endregion
    #region Metodos Publicos

    // Obtener último id
    public int Obtener_VProveedor_O_SiguienteCodigoProveedor()
    {
        try
        {
            return lnServicio.Obtener_VProveedor_O_SiguienteCodigoProveedor();
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Insertar
    public void Insertar_VProveedor_I(int codigoProveedor, string tipoProveedor, string razonSocialProveedor, string direccionProveedor, string celularProveedor, string correoProveedor)
    {
        try
        {
            lnServicio.Insertar_VProveedor_I(codigoProveedor, tipoProveedor, razonSocialProveedor, direccionProveedor, celularProveedor, correoProveedor);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener un registro
    public EVProveedor Obtener_VProveedor_O(int codigoProveedor)
    {
        try
        {
            return lnServicio.Obtener_VProveedor_O(codigoProveedor);
        }
        catch (Exception)
        {
            throw;
        }

    }
    // Actualizar
    public void Actualizar_VProveedor_A(int codigoProveedor, string tipoProveedor, string razonSocialProveedor, string direccionProveedor, string celularProveedor, string correoProveedor, string estado)
    {
        try
        {
            lnServicio.Actualizar_VProveedor_A(codigoProveedor, tipoProveedor, razonSocialProveedor, direccionProveedor, celularProveedor, correoProveedor, estado);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener todos los registros
    public List<EVProveedor> Obtener_VProveedor_O_Todo()
    {

        try
        {
            return lnServicio.Obtener_VProveedor_O_Todo();
        }
        catch (Exception)
        {
            throw;
        }

    }
    // Eliminar
    public void Eliminar_VProveedor_E(int codigoProveedor)
    {
        try
        {
            lnServicio.Eliminar_VProveedor_E(codigoProveedor);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

}