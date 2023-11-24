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

    #region Tabla: VProveedor
    public int Obtener_VProveedor_O_SiguienteCodigoProveedor()
    {
        int res = 0;
        try
        {
            res = swadNETVENTAS.Obtener_VProveedor_O_SiguienteCodigoProveedor();
            return res;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Insertar_VProveedor_I(EVProveedor proveedor)
    {

        try
        {
            swadNETVENTAS.Insertar_VProveedor_I(proveedor);
        }
        catch (Exception)
        {
            throw;
        }

    }
    public EVProveedor Obtener_VProveedor_O(int codigoProveedor)
    {
        EVProveedor eVProveedor = new EVProveedor();
        try
        {
            eVProveedor = swadNETVENTAS.Obtener_VProveedor_O(codigoProveedor);
            return eVProveedor;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_VProveedor_A(EVProveedor proveedor)
    {
        try
        {
            swadNETVENTAS.Actualizar_VProveedor_A(proveedor);

        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVProveedor> Obtener_VProveedor_O_Todo()
    {

        List<EVProveedor> lstVProveedor = new List<EVProveedor>();
        try
        {
            lstVProveedor = swadNETVENTAS.Obtener_VProveedor_O_Todo().ToList();
            return lstVProveedor;
        }
        catch (Exception)
        {
            throw;
        }

    }
    public void Eliminar_VProveedor_E(int codigoProveedor)
    {
        try
        {
            swadNETVENTAS.Eliminar_VProveedor_E(codigoProveedor);
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
            eVCliente = swadNETVENTAS.Obtener_VCliente_O(codigoCliente);
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

    #region Tabla: DetalleIngreso
    public int Obtener_VDetalleIngreso_O_SiguienteCodigoDetalleIngreso()
    {
        int res = 0;
        try
        {
            res = swadNETVENTAS.Obtener_VDetalleIngreso_O_SiguienteCodigoDetalleIngreso();
            return res;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Insertar_VDetalleIngreso_I(EVDetalleIngreso detalle)
    {

        try
        {
            swadNETVENTAS.Insertar_VDetalleIngreso_I(detalle);
        }
        catch (Exception)
        {
            throw;
        }

    }
    public EVDetalleIngreso Obtener_VDetalleIngreso_O_CodigoIngreso(int codigoIngreso)
    {
        EVDetalleIngreso eVDetalleIngreso = new EVDetalleIngreso();
        try
        {
            swadNETVENTAS.Obtener_VDetalleIngreso_O_CodigoIngreso(codigoIngreso);
            return eVDetalleIngreso;
        }
        catch (Exception)
        {
            throw;
        }
    }

    #endregion

    #region Tabla: VIngreso
    public int Obtener_VIngreso_O_SiguienteCodigoIngreso()
    {
        int res = 0;
        try
        {
            res = swadNETVENTAS.Obtener_VIngreso_O_SiguienteCodigoIngreso();
            return res;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Insertar_VIngreso_I(EVIngreso ingreso)
    {

        try
        {
            swadNETVENTAS.Insertar_VIngreso_I(ingreso);
        }
        catch (Exception)
        {
            throw;
        }

    }
    public EVIngreso Obtener_VIngreso_O(int codigoIngreso)
    {
        EVIngreso eVIngreso = new EVIngreso();
        try
        {
            eVIngreso = swadNETVENTAS.Obtener_VIngreso_O(codigoIngreso);
            return eVIngreso;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVIngreso> Obtener_VIngreso_O_Todo()
    {

        List<EVIngreso> lstVIngreso = new List<EVIngreso>();
        try
        {
            lstVIngreso = swadNETVENTAS.Obtener_VIngreso_O_Todo().ToList();
            return lstVIngreso;
        }
        catch (Exception)
        {
            throw;
        }

    }
    #endregion

    #region Tabla: VArticulo
    public int Obtener_VArticulo_O_SiguienteCodigoArticulo()
    {
        int respuesta = 0;
        try
        {
            respuesta = swadNETVENTAS.Obtener_VArticulo_O_SiguienteCodigoArticulo();
            return respuesta;
        }
        catch (Exception)
        {
            throw;
        }

    }
    public void Insertar_VArticulo_I(EVArticulo eVArticulo)
    {
        try
        {
            swadNETVENTAS.Insertar_VArticulo_I(eVArticulo);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EVArticulo Obtener_VArticulo_O(int codigoProyecto)
    {
        EVArticulo eVArticulo = new EVArticulo();
        try
        {
            eVArticulo = swadNETVENTAS.Obtener_VArticulo_O(codigoProyecto);
            return eVArticulo;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_VArticulo_A(EVArticulo eVArticulo)
    {
        try
        {
            swadNETVENTAS.Actualizar_VArticulo_A(eVArticulo);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVArticulo> Obtener_VArticulo_O_Todo()
    {
        try
        {
            return swadNETVENTAS.Obtener_VArticulo_O_Todo().ToList();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Eliminar_VArticulo_E(int codigoProyecto)
    {
        try
        {
            swadNETVENTAS.Eliminar_VArticulo_E(codigoProyecto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region Tabla: VDetalleVenta
    public int Obtener_VDetalleVenta_O_SiguienteCodigoDetalleVenta()
    {
        int respuesta = 0;
        try
        {
            respuesta = swadNETVENTAS.Obtener_VDetalleVenta_O_SiguienteCodigoDetalleVenta();
            return respuesta;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Insertar_VDetalleVenta_I(EVDetalleVenta eVDetalleVenta)
    {
        try
        {
            swadNETVENTAS.Insertar_VDetalleVenta_I(eVDetalleVenta);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVDetalleVenta> Obtener_VDetalleVenta_O_CodigoVenta(int codigoVenta)
    {
        try
        {
            return swadNETVENTAS.Obtener_VDetalleVenta_O_CodigoVenta(codigoVenta).ToList();
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region Tabla: VVenta
    // Obtener último id Venta
    public int Obtener_VVenta_O_SiguienteCodigoVenta()
    {
        int res = 0;
        try
        {
            res = swadNETVENTAS.Obtener_VVenta_O_SiguienteCodigoVenta();
            return res;
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Insertar
    public void Insertar_VVenta_I(EVVenta venta)
    {
        try
        {
            swadNETVENTAS.Insertar_VVenta_I(venta);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener un registro
    /*
    public EVVenta Obtener_VVenta_O(int codigoVenta)
    {
        EVVenta eVVenta = new EVVenta();
        try
        {
            eVVenta = swadNETVENTAS.Obtener_VVenta_O(codigoVenta);
            return eVVenta;
        }
        catch (Exception)
        {
            throw;
        }
    }*/
    /*
    // Actualizar
    public void Actualizar_VUsuario_A(EVUsuario usuario)
    {
        try
        {
            swadNETVENTAS.Actualizar_VUsuario_A(usuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener todos los registros
    public List<EVUsuario> Obtener_VUsuario_O_Todo()
    {
        List<EVUsuario> lstVUsuario = new List<EVUsuario>();
        try
        {
            lstVUsuario = swadNETVENTAS.Obtener_VUsuario_O_Todo().ToList();
            return lstVUsuario;
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Eliminar
    public void Eliminar_VUsuario_E(int codigoUsuario)
    {
        try
        {
            swadNETVENTAS.Eliminar_VUsuario_E(codigoUsuario);
        }
        catch (Exception)
        {
            throw;
        }

    }*/
    #endregion

    #region Tabla: VUsuario
    // Obtener último id
    public int Obtener_VUsuario_O_SiguienteCodigoUsuario()
    {
        int res = 0;
        try
        {
            res = swadNETVENTAS.Obtener_VUsuario_O_SiguienteCodigoUsuario();
            return res;
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Insertar
    public void Insertar_VUsuario_I(EVUsuario usuario)
    {
        try
        {
            swadNETVENTAS.Insertar_VUsuario_I(usuario);
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
            eVUsuario = swadNETVENTAS.Obtener_VUsuario_O(codigoUsuario);
            return eVUsuario;
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Actualizar
    public void Actualizar_VUsuario_A(EVUsuario usuario)
    {
        try
        {
            swadNETVENTAS.Actualizar_VUsuario_A(usuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener todos los registros
    public List<EVUsuario> Obtener_VUsuario_O_Todo()
    {
        List<EVUsuario> lstVUsuario = new List<EVUsuario>();
        try
        {
            lstVUsuario = swadNETVENTAS.Obtener_VUsuario_O_Todo().ToList();
            return lstVUsuario;
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Eliminar
    public void Eliminar_VUsuario_E(int codigoUsuario)
    {
        try
        {
            swadNETVENTAS.Eliminar_VUsuario_E(codigoUsuario);
        }
        catch (Exception)
        {
            throw;
        }

    }
    #endregion
}