using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CVArticulo
/// </summary>
public class CVArticulo
{
    #region Atributos
    private ADVArticulo adVArticulo;
    #endregion

    #region Constructor
    public CVArticulo()
    {
        adVArticulo = new ADVArticulo();
    }
    #endregion

    #region Métodos públicos
    public int Obtener_VArticulo_O_SiguienteCodigoArticulo()
    {
        Object res = adVArticulo.Obtener_VArticulo_O_UltimoCodigoArticulo();
        if (res.ToString().IsNullOrEmpty())
            return 1;
        else
            return (int)res + 1;
    }
    public void Insertar_VArticulo_I(EVArticulo articulo)
    {
        adVArticulo.Insertar_VArticulo_I(articulo);
    }
    public EVArticulo Obtener_VArticulo_O(int codigoArticulo)
    {
        EVArticulo eVArticulo = null;
        DTOVArticulo dtoVArticulo = adVArticulo.Obtener_VArticulo_O(codigoArticulo);
        foreach (DTOVArticulo.VArticuloRow dgVArticulo in dtoVArticulo.VArticulo.Rows)
        {
            eVArticulo = new EVArticulo();
            eVArticulo.CodigoArticulo = dgVArticulo.CodigoArticulo;
            eVArticulo.CategoriaArticulo = dgVArticulo.CategoriaArticulo;
            eVArticulo.NombreArticulo = dgVArticulo.NombreArticulo;
            eVArticulo.PrecioCompraArticulo = double.Parse(dgVArticulo.PrecioCompraArticulo.ToString());
            eVArticulo.PrecioVentaArticulo = double.Parse(dgVArticulo.PrecioVentaArticulo.ToString());
            eVArticulo.StockArticulo = dgVArticulo.StockArticulo;
        }
        return eVArticulo;
    }
    public void Actualizar_VArticulo_A(EVArticulo articulo)
    {
        adVArticulo.Actualizar_VArticulo_A(articulo);
    }
    public List<EVArticulo> Obtener_VArticulo_O_Todo()
    {
        EVArticulo eVArticulo;
        List<EVArticulo> lstEVArticulo = new List<EVArticulo>();
        DTOVArticulo dtoVArticulo = adVArticulo.Obtener_VArticulo_O_Todo();
        foreach (DTOVArticulo.VArticuloRow dgVArticulo in dtoVArticulo.VArticulo.Rows)
        {
            eVArticulo = new EVArticulo();
            eVArticulo.CodigoArticulo = dgVArticulo.CodigoArticulo;
            eVArticulo.CategoriaArticulo = dgVArticulo.CategoriaArticulo;
            eVArticulo.NombreArticulo = dgVArticulo.NombreArticulo;
            eVArticulo.PrecioCompraArticulo = double.Parse(dgVArticulo.PrecioCompraArticulo.ToString());
            eVArticulo.PrecioVentaArticulo = double.Parse(dgVArticulo.PrecioVentaArticulo.ToString());
            eVArticulo.StockArticulo = dgVArticulo.StockArticulo;
            lstEVArticulo.Add(eVArticulo);
        }
        return lstEVArticulo;
    }
    public void Eliminar_VArticulo_e(int codigoArticulo)
    {
        adVArticulo.Eliminar_VArticulo_E(codigoArticulo);
    }

    #endregion
}