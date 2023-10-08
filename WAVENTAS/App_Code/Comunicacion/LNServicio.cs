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

    #region Tabla: VProveedor
    // Obtener último id
    public int Obtener_VProveedor_O_SiguienteCodigoProveedor()
    {
        int resultado = 0;
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                resultado = swlnVENTAS.Obtener_VProveedor_O_SiguienteCodigoProveedor();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return resultado;
    }
    // Insertar
    public void Insertar_VProveedor_I(int codigoProveedor, string tipoProveedor, string razonSocialProveedor, string direccionProveedor, string celularProveedor, string correoProveedor)
    {
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                swlnVENTAS.Insertar_VProveedor_I(codigoProveedor, tipoProveedor, razonSocialProveedor, direccionProveedor, celularProveedor, correoProveedor);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener un registro
    public EVProveedor Obtener_VProveedor_O(int codigoProveedor)
    {
        EVProveedor eVProveedor = new EVProveedor();
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                eVProveedor = swlnVENTAS.Obtener_VProveedor_O(codigoProveedor);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eVProveedor;
    }
    // Actualizar
    public void Actualizar_VProveedor_A(int codigoProveedor, string tipoProveedor, string razonSocialProveedor, string direccionProveedor, string celularProveedor, string correoProveedor, string estado)
    {
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                swlnVENTAS.Actualizar_VProveedor_A(codigoProveedor, tipoProveedor, razonSocialProveedor, direccionProveedor, celularProveedor, correoProveedor ,estado);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener todos los registros
    public List<EVProveedor> Obtener_VProveedor_O_Todo()
    {
        List<EVProveedor> lstEVProveedor = new List<EVProveedor>();
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                lstEVProveedor = swlnVENTAS.Obtener_VProveedor_O_Todo().ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEVProveedor;
    }
    // Eliminar
    public void Eliminar_VProveedor_E(int codigoProveedor)
    {
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                swlnVENTAS.Eliminar_VProveedor_E(codigoProveedor);
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