using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CVCliente
/// </summary>
public class CVCliente
{
    #region Atributos
    private ADVCliente adVCliente;
    #endregion

    #region Constructor
    public CVCliente()
    {
        adVCliente = new ADVCliente();
    }
    #endregion

    #region Métodos públicos
    public int Obtener_VCliente_O_SiguienteCodigoCliente()
    {
        Object res = adVCliente.Obtener_VCliente_O_UltimoCodigoCliente();
        if (res.ToString().IsNullOrEmpty())
            return 1;
        else
            return (int)res + 1;
    }
    public void Insertar_VCliente_I(EVCliente cliente)
    {
        adVCliente.Insertar_VCliente_I(cliente);
    }
    public EVCliente Obtener_VCliente_O(int codigoCliente)
    {
        EVCliente eVCliente = null;
        DTOVCliente dtoVCliente = adVCliente.Obtener_VCliente_O(codigoCliente);
        foreach (DTOVCliente.VClienteRow drGCliente in dtoVCliente.VCliente.Rows)
        {
            eVCliente = new EVCliente();
            eVCliente.CodigoCliente = drGCliente.CodigoCliente;
            eVCliente.RazonSocialCliente = drGCliente.RazonSocialCliente;
            eVCliente.CiONitCliente = drGCliente.CiONitCliente;
            eVCliente.TipoCliente = drGCliente.TipoCliente;
            eVCliente.DirecionCliente = drGCliente.DirecionCliente;
            eVCliente.CelularCliente = drGCliente.CelularCliente;
            eVCliente.Estado = drGCliente.Estado;
            eVCliente.FechaRegistro = drGCliente.FechaRegistro;
            eVCliente.FechaActualizacion = drGCliente.FechaActualizacion;

        }
        return eVCliente;
    }
    public void Actualizar_VCliente_A(EVCliente cliente)
    {
        adVCliente.Actualizar_VCliente_A(cliente);
    }
    public List<EVCliente> Obtener_VClientes_O_Todo()
    {
        EVCliente eVCliente = null;
        List<EVCliente> lstEVCliente = new List<EVCliente>();
        DTOVCliente dtoVCliente = adVCliente.Obtener_VClientes_O_Todo();
        foreach (DTOVCliente.VClienteRow drVCliente in dtoVCliente.VCliente.Rows)
        {
            eVCliente = new EVCliente();
            eVCliente.CodigoCliente = drVCliente.CodigoCliente;
            eVCliente.RazonSocialCliente = drVCliente.RazonSocialCliente;
            eVCliente.CiONitCliente = drVCliente.CiONitCliente;
            eVCliente.TipoCliente = drVCliente.TipoCliente;
            eVCliente.DirecionCliente = drVCliente.DirecionCliente;
            eVCliente.CelularCliente = drVCliente.CelularCliente;
            eVCliente.Estado = drVCliente.Estado;
            eVCliente.FechaRegistro = drVCliente.FechaRegistro;
            eVCliente.FechaActualizacion = drVCliente.FechaActualizacion;
            lstEVCliente.Add(eVCliente);
        }
        return lstEVCliente;
    }
    public void Eliminar_VCliente_E(int codigoCliente)
    {
        adVCliente.Eliminar_VCliente_E(codigoCliente);
    }



    #endregion

}