using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CVVenta
/// </summary>
public class CVVenta
{
    #region Atributos
    private ADVVenta adVVenta;
    #endregion

    #region Constructor
    public CVVenta()
    {
        adVVenta = new ADVVenta();
    }
    #endregion

    #region Métodos públicos
    // Obtener último id
    public int Obtener_VVenta_O_SiguienteCodigoVenta()
    {
        Object res = adVVenta.Obtener_VVenta_O_UltimoCodigoVenta();
        if (res.ToString().IsNullOrEmpty())
            return 1;
        else
            return (int)res + 1;
    }
    // Insertar
    public void Insertar_VVenta_I(EVVenta venta)
    {
        adVVenta.Insertar_VVenta_I(venta);
    }
    // Obtener una venta
    public List<EVVenta> Obtener_VVenta_O(int codigoVenta)
    {
        EVVenta eVVenta = null;
        List<EVVenta> lstEVVenta = new List<EVVenta>();
        DTOVVenta dtoVVenta = adVVenta.Obtener_VVenta_O_CodigoVenta(codigoVenta);
        foreach (DTOVVenta.VVentaRow drVVenta in dtoVVenta.VVenta.Rows)
        {
            eVVenta.CodigoVenta = drVVenta.CodigoVenta;
            eVVenta.CodigoCliente = drVVenta.CodigoCliente;
            eVVenta.CodigoUsuario = drVVenta.CodigoUsuario;
            eVVenta.FechaHoraVenta = drVVenta.FechaHoraVenta;
            eVVenta.ImpuestoVenta = (double)drVVenta.ImpuestoVenta;
            eVVenta.TotalVenta = (double)drVVenta.TotalVenta;
            eVVenta.EstadoVenta = drVVenta.EstadoVenta;
            lstEVVenta.Add(eVVenta);
        }
        return lstEVVenta;
       
    }
    #endregion
}