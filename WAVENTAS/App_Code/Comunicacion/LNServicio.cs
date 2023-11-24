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

    #region Tabla: VProveedor
    // Obtener último id
    public int Obtener_VProveedor_O_SiguienteCodigoProveedor()
    {
        int resultado = 0;
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                resultado = swlnVENTAS.Obtener_VProveedor_O_SiguienteCodigoProveedor();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return resultado;
    }
    // Insertar
    public void Insertar_VProveedor_I(int codigoProveedor, string tipoProveedor, string razonSocialProveedor, string direccionProveedor, string celularProveedor, string correoProveedor)
    {
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                swlnVENTAS.Insertar_VProveedor_I(codigoProveedor, tipoProveedor, razonSocialProveedor, direccionProveedor, celularProveedor, correoProveedor);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener un registro
    public EVProveedor Obtener_VProveedor_O(int codigoProveedor)
    {
        EVProveedor eVProveedor = new EVProveedor();
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                eVProveedor = swlnVENTAS.Obtener_VProveedor_O(codigoProveedor);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eVProveedor;
    }
    // Actualizar
    public void Actualizar_VProveedor_A(int codigoProveedor, string tipoProveedor, string razonSocialProveedor, string direccionProveedor, string celularProveedor, string correoProveedor, string estado)
    {
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                swlnVENTAS.Actualizar_VProveedor_A(codigoProveedor, tipoProveedor, razonSocialProveedor, direccionProveedor, celularProveedor, correoProveedor ,estado);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener todos los registros
    public List<EVProveedor> Obtener_VProveedor_O_Todo()
    {
        List<EVProveedor> lstEVProveedor = new List<EVProveedor>();
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                lstEVProveedor = swlnVENTAS.Obtener_VProveedor_O_Todo().ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEVProveedor;
    }
    // Eliminar
    public void Eliminar_VProveedor_E(int codigoProveedor)
    {
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                swlnVENTAS.Eliminar_VProveedor_E(codigoProveedor);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

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

    #region VArticulo
    public int Obtener_VArticulo_O_SiguienteCodigoArticulo()
    {
        int resultado = 0;
        try
        {
            using (SWLNVENTASClient clienteSWLNVENTAS = new SWLNVENTASClient())
            {
                resultado = clienteSWLNVENTAS.Obtener_VArticulo_O_SiguienteCodigoArticulo();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return resultado;
    }
    public void Insertar_VArticulo_I(int codigoArticulo, string categoriaArticulo, string nombreArticulo, double precioCompraArticulo, double precioVentaArticulo, int stockArticulo)
    {
        try
        {
            using (SWLNVENTASClient clienteSWLNVENTAS = new SWLNVENTASClient())
            {
                clienteSWLNVENTAS.Insertar_VArticulo_I(codigoArticulo, categoriaArticulo, nombreArticulo, precioCompraArticulo, precioVentaArticulo, stockArticulo);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public EVArticulo Obtener_VArticulo_O(int codigoArticulo)
    {
        EVArticulo eVArticulo = new EVArticulo();
        try
        {
            using (SWLNVENTASClient clienteSWLNVENTAS = new SWLNVENTASClient())
            {
                eVArticulo = clienteSWLNVENTAS.Obtener_VArticulo_O(codigoArticulo);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eVArticulo;
    }
    public void Actualizar_VArticulo_A(int codigoArticulo, string categoriaArticulo, string nombreArticulo, double precioCompraArticulo, double precioVentaArticulo, int stockArticulo)
    {
        try
        {
            using (SWLNVENTASClient clienteSWLNVENTAS = new SWLNVENTASClient())
            {
                clienteSWLNVENTAS.Actualizar_VArticulo_A(codigoArticulo, categoriaArticulo, nombreArticulo, precioCompraArticulo, precioVentaArticulo, stockArticulo);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public List<EVArticulo> Obtener_VArticulo_O_Todo()
    {
        List<EVArticulo> lstEVArticulo = new List<EVArticulo>();
        try
        {
            using (SWLNVENTASClient clienteSWLNVENTAS = new SWLNVENTASClient())
            {
                lstEVArticulo = clienteSWLNVENTAS.Obtener_VArticulo_O_Todo().ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEVArticulo;
    }
    public void Eliminar_VArticulo_E(int codigoArticulo)
    {
        try
        {
            using (SWLNVENTASClient clienteSWLNVENTAS = new SWLNVENTASClient())
            {
                clienteSWLNVENTAS.Eliminar_VArticulo_E(codigoArticulo);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region Tabla: VVenta

    // Insertar
    public void Insertar_Venta(EVenta eVenta, List<EDetalleVenta> lstDetalleVenta)
    {
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                // Convierte la lista en un arreglo
                //EDetalleVenta[] arregloDetalleVenta = lstDetalleVenta.ToArray();
                swlnVENTAS.Insertar_Venta(eVenta, lstDetalleVenta.ToArray());
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener un registro
    /*
    public EVVenta Obtener_VVenta_O(int codigoUsuario)
    {
        EVVenta eVVenta = new EVVenta();
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                eVVenta = swlnVENTAS.Obtener_VVenta_O(codigoUsuario);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eVVenta;
    }*/
    #endregion

    #region Tabla: VUsuario
    // Obtener último id
    public int Obtener_VUsuario_O_SiguienteCodigoUsuario()
    {
        int resultado = 0;
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                resultado = swlnVENTAS.Obtener_VUsuario_O_SiguienteCodigoUsuario();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return resultado;
    }
    // Insertar
    public void Insertar_VUsuario_I(int codigoUsuario, string nombresUsuario, string apellidosUsuario, string celularUsuario, string correoUsuario, string claveUsuario, string rolUsuario)
    {
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                swlnVENTAS.Insertar_VUsuario_I(codigoUsuario, nombresUsuario, apellidosUsuario, celularUsuario, correoUsuario, claveUsuario, rolUsuario);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener un registro
    public EVUsuario Obtener_VUsuario_O(int codigoUsuario)
    {
        EVUsuario eVUsuario = new EVUsuario();
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                eVUsuario = swlnVENTAS.Obtener_VUsuario_O(codigoUsuario);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eVUsuario;
    }
    // Actualizar
    public void Actualizar_VUsuario_A(int codigoUsuario, string nombresUsuario, string apellidosUsuario, string celularUsuario, string correoUsuario, string claveUsuario, string rolUsuario, string estado)
    {
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                swlnVENTAS.Actualizar_VUsuario_A(codigoUsuario, nombresUsuario, apellidosUsuario, celularUsuario, correoUsuario, claveUsuario, rolUsuario, estado);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener todos los registros
    public List<EVUsuario> Obtener_VUsuario_O_Todo()
    {
        List<EVUsuario> lstEVUsuario = new List<EVUsuario>();
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                lstEVUsuario = swlnVENTAS.Obtener_VUsuario_O_Todo().ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEVUsuario;
    }
    // Eliminar
    public void Eliminar_VUsuario_E(int codigoUsuario)
    {
        try
        {
            using (SWLNVENTASClient swlnVENTAS = new SWLNVENTASClient())
            {
                swlnVENTAS.Eliminar_VUsuario_E(codigoUsuario);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #endregion
}