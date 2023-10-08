using SWLNVENTAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de LNServicio
/// </summary>
public class LNServicio
{
    #region Propiedades
    public string NombreClase
    {
        get { return GetType().Name; }
    }
    #endregion

    #region Constructor
    public LNServicio()
    {
    }
    #endregion

    #region Métodos públicos

    #region Tabla: VCliente
    public int Obtener_VCliente_O_SiguienteCodigoCliente()
    {
        int resultado = 0;
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                resultado = swlnVENTAS.Obtener_VCliente_O_SiguienteCodigoCliente();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return resultado;
    }
    // Insertar
    public void Insertar_VCliente_I(int codigoCliente, string razonSocialCliente, string ciONitCliente, string tipoCliente, string direcionCliente, string celularCliente)
    {
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                swlnVENTAS.Insertar_VCliente_I(codigoCliente, razonSocialCliente, ciONitCliente, tipoCliente, direcionCliente, celularCliente);
            }
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
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                eVCliente = swlnVENTAS.Obtener_VCliente_O(codigoCliente);
            }
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
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                swlnVENTAS.Actualizar_VCliente_A(codigoCliente, razonSocialCliente, ciONitCliente, tipoCliente, direcionCliente, celularCliente, estado);
            }
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
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                lstEVCliente = swlnVENTAS.Obtener_VClientes_O_Todo().ToList();
            }
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
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                swlnVENTAS.Eliminar_VCliente_E(codigoCliente);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region Registro Almacen

    // Insertar
    public void Insertar_Ingreso(EIngreso ingreso, List<EDetalleIngreso> detalleIngresos)
    {

        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                swlnVENTAS.Insertar_Ingreso(ingreso, detalleIngresos.ToArray());
            }
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

    #endregion
}