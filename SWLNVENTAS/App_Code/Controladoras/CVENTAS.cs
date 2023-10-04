using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SWADNETVENTAS;

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

    #region Tabla: VArticulo
    public int Obtener_VArticulo_O_SiguienteCodigoArticulo()
    {
        try
        {
            return asNETVENTAS.Obtener_VArticulo_O_SiguienteCodigoArticulo();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Insertar_VArticulo_I(int codigoArticulo, string categoriaArticulo, string nombreArticulo, double precioCompraArticulo, double precioVentaArticulo, int stockArticulo)
    {
        EVArticulo eVArticulo = new EVArticulo();
        try
        {
            eVArticulo.CodigoArticulo = codigoArticulo;
            eVArticulo.CategoriaArticulo = categoriaArticulo;
            eVArticulo.NombreArticulo = nombreArticulo;
            eVArticulo.PrecioCompraArticulo = precioCompraArticulo;
            eVArticulo.PrecioVentaArticulo = precioVentaArticulo;
            eVArticulo.StockArticulo = stockArticulo;
            asNETVENTAS.Insertar_VArticulo_I(eVArticulo);
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
            eVArticulo = asNETVENTAS.Obtener_VArticulo_O(codigoArticulo);
            return eVArticulo;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_VArticulo_A(int codigoArticulo, string categoriaArticulo, string nombreArticulo, double precioCompraArticulo, double precioVentaArticulo, int stockArticulo)
    {
        EVArticulo eVArticulo = new EVArticulo();
        try
        {
            eVArticulo.CodigoArticulo = codigoArticulo;
            eVArticulo.CategoriaArticulo = categoriaArticulo;
            eVArticulo.NombreArticulo = nombreArticulo;
            eVArticulo.PrecioCompraArticulo = precioCompraArticulo;
            eVArticulo.PrecioVentaArticulo = precioVentaArticulo;
            eVArticulo.StockArticulo = stockArticulo;
            asNETVENTAS.Actualizar_VArticulo_A(eVArticulo);
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
            return asNETVENTAS.Obtener_VArticulo_O_Todo().ToList();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Eliminar_VArticulo_E(int codigoArticulo)
    {
        try
        {
            asNETVENTAS.Eliminar_VArticulo_E(codigoArticulo);
        }
        catch (Exception)
        {
            throw;
        }
    }

    #endregion

    #region Tabla: VDetalleArticulo
    public int Obtener_VDetalleVenta_O_SiguienteCodigoDetalleVenta()
    {
        try
        {
            return asNETVENTAS.Obtener_VArticulo_O_SiguienteCodigoArticulo();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Insertar_VDetalleVenta_I(int codigoDetalleVenta, int codigoVenta, int codigoArticulo, int cantidadDetalleVenta, double precioDetalleVenta, double descuentoDetalleVenta)
    {
        EVDetalleVenta eVDetalleVenta = new EVDetalleVenta();
        try
        {
            eVDetalleVenta.CodigoDetalleVenta = codigoDetalleVenta;
            eVDetalleVenta.CodigoVenta = codigoVenta;
            eVDetalleVenta.CodigoArticulo = codigoArticulo;
            eVDetalleVenta.CantidadDetalleVenta = cantidadDetalleVenta;
            eVDetalleVenta.PrecioDetalleVenta = precioDetalleVenta;
            eVDetalleVenta.DescuentoDetalleVenta = descuentoDetalleVenta;
            asNETVENTAS.Insertar_VDetalleVenta_I(eVDetalleVenta);
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
            return asNETVENTAS.Obtener_VDetalleVenta_O_CodigoVenta(codigoVenta).ToList();
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