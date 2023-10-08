using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CVIngreso
/// </summary>
public class CVIngreso
{
    #region Atributos
    private ADVIngreso adVIngreso;
    #endregion

    #region Constructor
    public CVIngreso()
    {
        adVIngreso = new ADVIngreso();
    }
    #endregion

    #region Métodos públicos
    public int Obtener_VIngreso_O_SiguienteCodigoIngreso()
    {
        Object res = adVIngreso.Obtener_VIngreso_O_UltimoCodigoIngreso();
        if (res.ToString().IsNullOrEmpty())
            return 1;
        else
            return (int)res + 1;
    }
    public void Insertar_VIngreso_I(EVIngreso eVIngreso)
    {
        adVIngreso.Insertar_VIngreso_I(eVIngreso);
    }
    public EVIngreso Obtener_VIngreso_O(int codigoIngreso)
    {
        EVIngreso eVIngreso = null;
        DTOVIngreso dtoVIngreso = adVIngreso.Obtener_VIngreso_O(codigoIngreso);
        foreach (DTOVIngreso.VIngresoRow drVIngreso in dtoVIngreso.VIngreso.Rows)
        {
            eVIngreso = new EVIngreso();
            eVIngreso.CodigoIngreso = drVIngreso.CodigoProveedor;
            eVIngreso.CodigoProveedor = drVIngreso.CodigoProveedor;
            eVIngreso.CodigoUsuario = drVIngreso.CodigoUsuario;
            eVIngreso.FechaIngreso = drVIngreso.FechaIngreso;
            eVIngreso.ImpuestoIngreso = drVIngreso.ImpuestoIngreso;
            eVIngreso.TotalIngreso = drVIngreso.TotalIngreso;
            eVIngreso.EstadoIngreso = drVIngreso.EstadoIngreso;
        }
        return eVIngreso;
    }
    public List<EVIngreso> Obtener_VIngreso_O_Todo()
    {
        EVIngreso eVIngreso = null;
        List<EVIngreso> lstEVIngreso = new List<EVIngreso>();
        DTOVIngreso dtoVIngreso = adVIngreso.Obtener_VIngreso_O_Todo();
        foreach (DTOVIngreso.VIngresoRow drVIngreso in dtoVIngreso.VIngreso.Rows)
        {
            eVIngreso = new EVIngreso();
            eVIngreso.CodigoIngreso = drVIngreso.CodigoProveedor;
            eVIngreso.CodigoProveedor = drVIngreso.CodigoProveedor;
            eVIngreso.CodigoUsuario = drVIngreso.CodigoUsuario;
            eVIngreso.FechaIngreso = drVIngreso.FechaIngreso;
            eVIngreso.ImpuestoIngreso = drVIngreso.ImpuestoIngreso;
            eVIngreso.TotalIngreso = drVIngreso.TotalIngreso;
            eVIngreso.EstadoIngreso = drVIngreso.EstadoIngreso;
            lstEVIngreso.Add(eVIngreso);
        }
        return lstEVIngreso;

    }
    #endregion
}


































































