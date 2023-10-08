using SWADNETVENTAS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;


/// <summary>
/// Descripción breve de CVENTAS
/// </summary>
public class CVENTAS
{
    #region Atributos
    private ASNETVENTAS asNETVENTAS;
    #endregion

    #region Constructor
    public CVENTAS()
    {
        asNETVENTAS = new ASNETVENTAS();
    }
    #endregion

    #region Tabla: VProveedor
    public int Obtener_VProveedor_O_SiguienteCodigoProveedor()
    {
        try
        {
            return asNETVENTAS.Obtener_VProveedor_O_SiguienteCodigoProveedor();
        }
        catch (Exception)
        {
            throw;
        }
    }


    public void Insertar_VProveedor_I(int codigoProveedor, string tipoProveedor, string razonSocialProveedor, string direccionProveedor, string celularProveedor, string correoProveedor)
    {
        EVProveedor eVProveedor = new EVProveedor();
        try
        {
            eVProveedor.CodigoProveedor = codigoProveedor;
            eVProveedor.TipoProveedor = tipoProveedor;
            eVProveedor.RazonSocialProveedor = razonSocialProveedor;
            eVProveedor.DireccionProveedor = direccionProveedor;
            eVProveedor.CelularProveedor = celularProveedor;
            eVProveedor.CorreoProveedor = correoProveedor;
            asNETVENTAS.Insertar_VProveedor_I(eVProveedor);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EVProveedor Obtener_VProveedor_O(int codigoProveedor)
    {
        try
        {
            return asNETVENTAS.Obtener_VProveedor_O(codigoProveedor);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_VProveedor_A(int codigoProveedor, string tipoProveedor, string razonSocialProveedor, string direccionProveedor, string celularProveedor, string correoProveedor,string estado)
    {
        EVProveedor eVProveedor = new EVProveedor();
        try
        {
            eVProveedor.CodigoProveedor = codigoProveedor;
            eVProveedor.TipoProveedor = tipoProveedor;
            eVProveedor.RazonSocialProveedor = razonSocialProveedor;
            eVProveedor.DireccionProveedor = direccionProveedor;
            eVProveedor.CelularProveedor = celularProveedor;
            eVProveedor.CorreoProveedor = correoProveedor;
            eVProveedor.Estado = estado;
            asNETVENTAS.Actualizar_VProveedor_A(eVProveedor);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVProveedor> Obtener_VProveedor_O_Todo()
    {
        try
        {
            return asNETVENTAS.Obtener_VProveedor_O_Todo().ToList();
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
            asNETVENTAS.Eliminar_VProveedor_E(codigoProveedor);
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

    #region  Resgistro Almacen 
    public void Insertar_Ingreso(EVIngreso ingreso)
    {
        try
        {
            int codigoIngreso = asNETVENTAS.Obtener_VIngreso_O_SiguienteCodigoIngreso();
            asNETVENTAS.Insertar_VIngreso_I(ingreso);
            //insertar_VVenta_I(venta);
            //foreach (var item in detalleVenta)
            //    insertar_VDetalleVenta_I(item);
        }
        catch (Exception)
        {
            throw;
        }
    }

    #endregion
}