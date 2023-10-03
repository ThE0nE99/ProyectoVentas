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

    #region Tabla: VProveedor
    public int Obtener_VProveedor_O_SiguienteCodigoProveedor()
    {
        int res = 0;
        try
        {
            res = swadNETVENTAS.Obtener_VProveedor_O_SiguienteCodigoProveedor();
            return res;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Insertar_VProveedor_I(EVProveedor proveedor)
    {

        try
        {
            swadNETVENTAS.Insertar_VProveedor_I(proveedor);
        }
        catch (Exception)
        {
            throw;
        }

    }
    public EVProveedor Obtener_VProveedor_O(int codigoProveedor)
    {
        EVProveedor eVProveedor = new EVProveedor();
        try
        {
            eVProveedor = swadNETVENTAS.Obtener_VProveedor_O(codigoProveedor);
            return eVProveedor;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_VProveedor_A(EVProveedor proveedor)
    {
        try
        {
            swadNETVENTAS.Actualizar_VProveedor_A(proveedor);

        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVProveedor> Obtener_VProveedor_O_Todo()
    {

        List<EVProveedor> lstVProveedor = new List<EVProveedor>();
        try
        {
            lstVProveedor = swadNETVENTAS.Obtener_VProveedor_O_Todo().ToList();
            return lstVProveedor;
        }
        catch (Exception)
        {
            throw;
        }

    }
    public void Eliminar_VProveedor_E(int codigoProveedor)
    {
        try
        {
            swadNETVENTAS.Eliminar_VProveedor_E(codigoProveedor);
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
}