using System;
using System.Collections.Generic;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CVProveedor
/// </summary>
public class CVProveedor
{
    #region Atributos
    private ADVProveedor adVProveedor;
    #endregion

    #region Constructor
    public CVProveedor()
    {
        adVProveedor = new ADVProveedor();
    }
    #endregion

    #region Métodos públicos
    public int Obtener_VProveedor_O_SiguienteCodigoProveedor()
    {
        Object res = adVProveedor.Obtener_VProveedor_O_UltimoCodigoProveedor();
        if (res.ToString().IsNullOrEmpty())
            return 1;
        else
            return (int)res + 1;
    }
    public void Insertar_VProveedor_I(EVProveedor eVProveedor)
    {
        adVProveedor.Insertar_VProveedor_I(eVProveedor);
    }
    public EVProveedor Obtener_VProveedor_O(int codigoProveedor)
    {
        EVProveedor eVProveedor = null;
        DTOVProveedor dtoVProveedor = adVProveedor.Obtener_VProveedor_O(codigoProveedor);
        foreach (DTOVProveedor.VProveedorRow drVProveedor in dtoVProveedor.VProveedor.Rows)
        {
            eVProveedor = new EVProveedor();
            eVProveedor.CodigoProveedor = drVProveedor.CodigoProveedor;
            eVProveedor.TipoProveedor = drVProveedor.TipoProveedor;
            eVProveedor.RazonSocialProveedor = drVProveedor.RazonSocialProveedor;
            eVProveedor.DireccionProveedor = drVProveedor.DireccionProveedor;
            eVProveedor.CelularProveedor = drVProveedor.CelularProveedor;
            eVProveedor.CorreoProveedor = drVProveedor.CorreoProveedor;
            eVProveedor.Estado = drVProveedor.Estado;
            eVProveedor.FechaRegistro = drVProveedor.FechaRegistro;
            eVProveedor.FechaActualizacion = drVProveedor.FechaActualizacion;
        }
        return eVProveedor;
    }
    public void Actualizar_VProveedor_A(EVProveedor proveedor)
    {
        adVProveedor.Actualizar_VProveedor_A(proveedor);
    }
    public List<EVProveedor> Obtener_VProveedor_O_Todo()
    {
        EVProveedor eVProveedor = null;
        List<EVProveedor> lstEVProveedor = new List<EVProveedor>();
        DTOVProveedor dtoVProveedor = adVProveedor.Obtener_VProveedor_O_Todo();
        foreach (DTOVProveedor.VProveedorRow drVProveedor in dtoVProveedor.VProveedor.Rows)
        {
            eVProveedor = new EVProveedor();
            eVProveedor.CodigoProveedor = drVProveedor.CodigoProveedor;
            eVProveedor.TipoProveedor = drVProveedor.TipoProveedor;
            eVProveedor.RazonSocialProveedor = drVProveedor.RazonSocialProveedor;
            eVProveedor.DireccionProveedor = drVProveedor.DireccionProveedor;
            eVProveedor.CelularProveedor = drVProveedor.CelularProveedor;
            eVProveedor.CorreoProveedor = drVProveedor.CorreoProveedor;
            eVProveedor.Estado = drVProveedor.Estado;
            eVProveedor.FechaRegistro = drVProveedor.FechaRegistro;
            eVProveedor.FechaActualizacion = drVProveedor.FechaActualizacion;
            lstEVProveedor.Add(eVProveedor);
        }
        return lstEVProveedor;

    }
    public void Eliminar_VProveedor_E(int codigoProveedor)
    {
        adVProveedor.Eliminar_VProveedor_E(codigoProveedor);
    }
    #endregion
}