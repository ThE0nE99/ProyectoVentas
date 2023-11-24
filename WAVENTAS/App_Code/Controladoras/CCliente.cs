using SWLNVENTAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CCliente
/// </summary>
public class CCliente
{
    #region Atributos
    private LNServicio lnServicio;
    #endregion



    #region Propiedades
    public string NombreClase
    {
        get { return GetType().Name; }
    }
    #endregion


    #region Constructor
    public CCliente()
    {
        lnServicio = new LNServicio();
    }
    #endregion

    #region Metodos Publicos
    // Obtener último id
    public int Obtener_VCliente_O_SiguienteCodigoCliente()
    {
        try
        {
            return lnServicio.Obtener_VCliente_O_SiguienteCodigoCliente();
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Insertar
    public void Insertar_VCliente_I(int codigoCliente, string razonSocialCliente, string ciONitCliente, string tipoCliente, string direcionCliente, string celularCliente)
    {
        try
        {
            lnServicio.Insertar_VCliente_I(codigoCliente, razonSocialCliente, ciONitCliente, tipoCliente, direcionCliente, celularCliente);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener un registro
    public EVCliente Obtener_VCliente_O(int codigoCliente)
    {
        EVCliente eVCliente = new EVCliente();
        try
        {
            eVCliente = lnServicio.Obtener_VCliente_O(codigoCliente);
        }
        catch (Exception)
        {
            throw;
        }
        return eVCliente;
    }
    // Actualizar
    public void Actualizar_VCliente_A(int codigoCliente, string razonSocialCliente, string ciONitCliente, string tipoCliente, string direcionCliente, string celularCliente, string estado)
    {
        try
        {
            lnServicio.Actualizar_VCliente_A(codigoCliente, razonSocialCliente, ciONitCliente, tipoCliente, direcionCliente, celularCliente, estado);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener todos los registros
    public List<EVCliente> Obtener_VClientes_O_Todo()
    {
        List<EVCliente> lstEVCliente = new List<EVCliente>();
        try
        {
            lstEVCliente = lnServicio.Obtener_VClientes_O_Todo();
        }
        catch (Exception)
        {
            throw;
        }
        return lstEVCliente;
    }
    // Eliminar
    public void Eliminar_VCliente_E(int codigoCliente)
    {
        try
        {
            lnServicio.Eliminar_VCliente_E(codigoCliente);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

}