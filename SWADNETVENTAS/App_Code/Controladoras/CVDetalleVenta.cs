using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CVDetalleVenta
/// </summary>
public class CVDetalleVenta
{
    #region Atributos
    private ADVDetalleVenta adVDetalleVenta;
    #endregion

    #region Constructor
    public CVDetalleVenta()
    {
        adVDetalleVenta = new ADVDetalleVenta();
    }
    #endregion

    #region Métodos públicos
    public int Obtener_VDetalleVenta_O_SiguienteCodigoDetalleVenta()
    {
        Object res = adVDetalleVenta.Obtener_VDetalleVenta_O_UltimoCodigoDetalleVenta();
        if (res.ToString().IsNullOrEmpty())
            return 1;
        else
            return (int)res + 1;
    }
    public void Insertar_VDetalleVenta_I(EVDetalleVenta detalleVenta)
    {
        adVDetalleVenta.Insertar_VDetalleVenta_I(detalleVenta);
    }
    public List<EVDetalleVenta> Obtener_VDetalleVenta_O_CodigoVenta(int codigoVenta)
    {
        EVDetalleVenta eVDetalleVenta;
        List<EVDetalleVenta> lstEVDetalleVenta = new List<EVDetalleVenta>();
        DTOVDetalleVenta dtoVDetalleVenta = adVDetalleVenta.Obtener_VDetalleVenta_O_CodigoVenta(codigoVenta);
        foreach (DTOVDetalleVenta.VDetalleVentaRow dgVDetalleVenta in dtoVDetalleVenta.VDetalleVenta.Rows)
        {
            eVDetalleVenta = new EVDetalleVenta();
            eVDetalleVenta.CodigoDetalleVenta = dgVDetalleVenta.CodigoDetalleVenta;
            eVDetalleVenta.CodigoVenta = dgVDetalleVenta.CodigoVenta;
            eVDetalleVenta.CodigoArticulo = dgVDetalleVenta.CodigoArticulo;
            eVDetalleVenta.CantidadDetalleVenta = dgVDetalleVenta.CantidadDetalleVenta;
            eVDetalleVenta.PrecioDetalleVenta = double.Parse(dgVDetalleVenta.PrecioDetalleVenta.ToString());
            eVDetalleVenta.DescuentoDetalleVenta = double.Parse(dgVDetalleVenta.DescuentoDetalleVenta.ToString());
            lstEVDetalleVenta.Add(eVDetalleVenta);
        }
        return lstEVDetalleVenta;
    }

    #endregion
}