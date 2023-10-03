using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SWADNETVENTAS;

/// <summary>
/// Descripción breve de ASNETVENTAS
/// </summary>
public class ASNETVENTAS
{
    #region Atributos
    private SWADNETVENTASClient swadNETVENTAS;
    #endregion

    #region Constructor
    public ASNETVENTAS()
    {
        swadNETVENTAS = new SWADNETVENTASClient();
    }
    #endregion

    #region Tabla: VCliente
    public int Obtener_VCliente_O_SiguienteCodigoCliente()
    {
        int res = 0;
        try
        {
            res = swadNETVENTAS.Obtener_VCliente_O_SiguienteCodigoCliente();
            return res;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Insertar_VCliente_I(EVCliente cliente)
    {

        try
        {
            swadNETVENTAS.Insertar_VCliente_I(cliente);
        }
        catch (Exception)
        {
            throw;
        }

    }
    public EVCliente Obtener_VCliente_O(int codigoCliente)
    {
        EVCliente eVCliente = new EVCliente();
        try
        {
            swadNETVENTAS.Obtener_VCliente_O(codigoCliente);
            return eVCliente;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_VCliente_A(EVCliente cliente)
    {
        try
        {
            swadNETVENTAS.Actualizar_VCliente_A(cliente);

        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVCliente> Obtener_VClientes_O_Todo()
    {

        List<EVCliente> lstVCliente = new List<EVCliente>();
        try
        {
            lstVCliente = swadNETVENTAS.Obtener_VClientes_O_Todo().ToList();
            return lstVCliente;
        }
        catch (Exception)
        {
            throw;
        }

    }
    public void Eliminar_VCliente_E(int codigoCliente)
    {
        try
        {
            swadNETVENTAS.Eliminar_VCliente_E(codigoCliente);
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
}