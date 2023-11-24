using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CVDetalleIngreso
/// </summary>
public class CVDetalleIngreso
{
    #region Atributos
    private ADVDetalleIngreso adVDetalle;
    #endregion

    #region Constructor
    public CVDetalleIngreso()
    {
        adVDetalle = new ADVDetalleIngreso();
    }
    #endregion

    #region Métodos públicos
    public int Obtener_VDetalleIngreso_O_SiguienteDetalleIngreso()
    {
        Object res = adVDetalle.Obtener_VDetalleIngreso_O_UltimoCodigoDetalleIngreso();
        if (res.ToString().IsNullOrEmpty())
            return 1;
        else
            return (int)res + 1;
    }
    public void Insertar_VDetalleIngreso_I(EVDetalleIngreso detalle)
    {
        adVDetalle.Insertar_VDetalleIngreso_I(detalle);
    }
    public EVDetalleIngreso Obtener_VDetalleIngreso_O_CodigoIngreso(int codigoIngreso)
    {
        EVDetalleIngreso eVDetalle = null;
        DTOVDetalleIngreso dtoVDetalle = adVDetalle.Obtener_VDetalleIngreso_O_CodigoIngreso(codigoIngreso);
        foreach (DTOVDetalleIngreso.VDetalleIngresoRow drGDetalle in dtoVDetalle.VDetalleIngreso.Rows)
        {
            eVDetalle = new EVDetalleIngreso();
            eVDetalle.CodigoDetalleIngreso = drGDetalle.CodigoIngreso;
            eVDetalle.CodigoIngreso = drGDetalle.CodigoIngreso;
            eVDetalle.CodigoArticulo = drGDetalle.CodigoArticulo;
            eVDetalle.CantidadIngreso = drGDetalle.CantidadIngreso;
            eVDetalle.PrecioIngreso = (double)drGDetalle.PrecioIngreso;
        }
        return eVDetalle;
    }
    #endregion
}