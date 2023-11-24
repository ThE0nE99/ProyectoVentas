using SWADNETVENTAS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;


/// <summary>
/// Descripción breve de CVENTAS
/// </summary>
public class CVENTAS
{
    #region Atributos
    private ASNETVENTAS asNETVENTAS;
    #endregion

    #region Constructor
    public CVENTAS()
    {
        asNETVENTAS = new ASNETVENTAS();
    }
    #endregion

    #region Tabla: VProveedor
    public int Obtener_VProveedor_O_SiguienteCodigoProveedor()
    {
        try
        {
            return asNETVENTAS.Obtener_VProveedor_O_SiguienteCodigoProveedor();
        }
        catch (Exception)
        {
            throw;
        }
    }


    public void Insertar_VProveedor_I(int codigoProveedor, string tipoProveedor, string razonSocialProveedor, string direccionProveedor, string celularProveedor, string correoProveedor)
    {
        EVProveedor eVProveedor = new EVProveedor();
        try
        {
            eVProveedor.CodigoProveedor = codigoProveedor;
            eVProveedor.TipoProveedor = tipoProveedor;
            eVProveedor.RazonSocialProveedor = razonSocialProveedor;
            eVProveedor.DireccionProveedor = direccionProveedor;
            eVProveedor.CelularProveedor = celularProveedor;
            eVProveedor.CorreoProveedor = correoProveedor;
            asNETVENTAS.Insertar_VProveedor_I(eVProveedor);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EVProveedor Obtener_VProveedor_O(int codigoProveedor)
    {
        try
        {
            return asNETVENTAS.Obtener_VProveedor_O(codigoProveedor);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_VProveedor_A(int codigoProveedor, string tipoProveedor, string razonSocialProveedor, string direccionProveedor, string celularProveedor, string correoProveedor,string estado)
    {
        EVProveedor eVProveedor = new EVProveedor();
        try
        {
            eVProveedor.CodigoProveedor = codigoProveedor;
            eVProveedor.TipoProveedor = tipoProveedor;
            eVProveedor.RazonSocialProveedor = razonSocialProveedor;
            eVProveedor.DireccionProveedor = direccionProveedor;
            eVProveedor.CelularProveedor = celularProveedor;
            eVProveedor.CorreoProveedor = correoProveedor;
            eVProveedor.Estado = estado;
            asNETVENTAS.Actualizar_VProveedor_A(eVProveedor);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVProveedor> Obtener_VProveedor_O_Todo()
    {
        try
        {
            return asNETVENTAS.Obtener_VProveedor_O_Todo().ToList();
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
            asNETVENTAS.Eliminar_VProveedor_E(codigoProveedor);
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

        try
        {
            return asNETVENTAS.Obtener_VCliente_O_SiguienteCodigoCliente();
        }
        catch (Exception)
        {
            throw;
        }
    }



    public void Insertar_VCliente_I(int codigoCliente, string razonSocialCliente, string ciONitCliente, string tipoCliente, string direcionCliente, string celularCliente)
    {
        EVCliente eVCliente = new EVCliente();
        try
        {
            eVCliente.CodigoCliente = codigoCliente;
            eVCliente.RazonSocialCliente = razonSocialCliente;
            eVCliente.CiONitCliente = ciONitCliente;
            eVCliente.TipoCliente = tipoCliente;
            eVCliente.DirecionCliente = direcionCliente;
            eVCliente.CelularCliente = celularCliente;
            asNETVENTAS.Insertar_VCliente_I(eVCliente);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EVCliente Obtener_VCliente_O(int codigoCliente)
    {
        try
        {
            return asNETVENTAS.Obtener_VCliente_O(codigoCliente);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_VCliente_A(int codigoCliente, string razonSocialCliente, string ciONitCliente, string tipoCliente, string direcionCliente, string celularCliente, string estado)
    {
        EVCliente eVCliente = new EVCliente();
        try
        {
            eVCliente.CodigoCliente = codigoCliente;
            eVCliente.RazonSocialCliente = razonSocialCliente;
            eVCliente.CiONitCliente = ciONitCliente;
            eVCliente.TipoCliente = tipoCliente;
            eVCliente.DirecionCliente = direcionCliente;
            eVCliente.CelularCliente = celularCliente;
            eVCliente.Estado = estado;
            asNETVENTAS.Actualizar_VCliente_A(eVCliente);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVCliente> Obtener_VClientes_O_Todo()
    {

        try
        {
            return asNETVENTAS.Obtener_VClientes_O_Todo().ToList();
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
            asNETVENTAS.Eliminar_VCliente_E(codigoCliente);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region Registro Ingreso

    public void Insertar_Ingreso(EIngreso ingreso, List<EDetalleIngreso> detalleIngresos)
    {
        try
        {
            EVIngreso eVIngreso = new EVIngreso();
            eVIngreso.CodigoIngreso = asNETVENTAS.Obtener_VIngreso_O_SiguienteCodigoIngreso();
            eVIngreso.CodigoProveedor = ingreso.CodigoProveedor;
            eVIngreso.CodigoUsuario = ingreso.CodigoUsuario;
            eVIngreso.FechaIngreso = ingreso.FechaIngreso;
            eVIngreso.ImpuestoIngreso = ingreso.ImpuestoIngreso;
            eVIngreso.TotalIngreso = ingreso.TotalIngreso;
            eVIngreso.EstadoIngreso = ingreso.EstadoIngreso;
            asNETVENTAS.Insertar_VIngreso_I(eVIngreso);
            EVDetalleIngreso eVDetalleIngreso = null;
            foreach (EDetalleIngreso item in detalleIngresos)
            {
                eVDetalleIngreso = new EVDetalleIngreso();
                eVDetalleIngreso.CodigoDetalleIngreso = asNETVENTAS.Obtener_VDetalleIngreso_O_SiguienteCodigoDetalleIngreso();
                eVDetalleIngreso.CodigoIngreso = eVIngreso.CodigoIngreso;
                eVDetalleIngreso.CodigoArticulo = item.CodigoArticulo;
                eVDetalleIngreso.CantidadIngreso = item.CantidadIngreso;
                eVDetalleIngreso.PrecioIngreso = item.PrecioIngreso;
                asNETVENTAS.Insertar_VDetalleIngreso_I(eVDetalleIngreso);
            }
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
        try
        {
            return asNETVENTAS.Obtener_VArticulo_O_SiguienteCodigoArticulo();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Insertar_VArticulo_I(int codigoArticulo, string categoriaArticulo, string nombreArticulo, double precioCompraArticulo, double precioVentaArticulo, int stockArticulo)
    {
        EVArticulo eVArticulo = new EVArticulo();
        try
        {
            eVArticulo.CodigoArticulo = codigoArticulo;
            eVArticulo.CategoriaArticulo = categoriaArticulo;
            eVArticulo.NombreArticulo = nombreArticulo;
            eVArticulo.PrecioCompraArticulo = precioCompraArticulo;
            eVArticulo.PrecioVentaArticulo = precioVentaArticulo;
            eVArticulo.StockArticulo = stockArticulo;
            asNETVENTAS.Insertar_VArticulo_I(eVArticulo);
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
            eVArticulo = asNETVENTAS.Obtener_VArticulo_O(codigoArticulo);
            return eVArticulo;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_VArticulo_A(int codigoArticulo, string categoriaArticulo, string nombreArticulo, double precioCompraArticulo, double precioVentaArticulo, int stockArticulo)
    {
        EVArticulo eVArticulo = new EVArticulo();
        try
        {
            eVArticulo.CodigoArticulo = codigoArticulo;
            eVArticulo.CategoriaArticulo = categoriaArticulo;
            eVArticulo.NombreArticulo = nombreArticulo;
            eVArticulo.PrecioCompraArticulo = precioCompraArticulo;
            eVArticulo.PrecioVentaArticulo = precioVentaArticulo;
            eVArticulo.StockArticulo = stockArticulo;
            asNETVENTAS.Actualizar_VArticulo_A(eVArticulo);
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
            return asNETVENTAS.Obtener_VArticulo_O_Todo().ToList();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Eliminar_VArticulo_E(int codigoArticulo)
    {
        try
        {
            asNETVENTAS.Eliminar_VArticulo_E(codigoArticulo);
        }
        catch (Exception)
        {
            throw;
        }
    }

    #endregion

    #region Tabla: VDetalleV
    public int Obtener_VDetalleVenta_O_SiguienteCodigoDetalleVenta()
    {
        try
        {
            return asNETVENTAS.Obtener_VDetalleVenta_O_SiguienteCodigoDetalleVenta();
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
            return asNETVENTAS.Obtener_VDetalleVenta_O_CodigoVenta(codigoVenta).ToList();
        }
        catch (Exception)
        {
            throw;
        }
    }

    #endregion

    #region Registo de la Venta
    // Insertar
    public void Insertar_Venta(EVenta eVenta, List<EDetalleVenta> lstDetalleVenta)
    {
        EVVenta eVVenta = new EVVenta();
        try
        {
            eVVenta.CodigoVenta = asNETVENTAS.Obtener_VVenta_O_SiguienteCodigoVenta();
            eVVenta.CodigoCliente = eVenta.CodigoCliente;
            eVVenta.CodigoUsuario = eVenta.CodigoUsuario;
            eVVenta.FechaHoraVenta = eVenta.FechaHoraVenta;
            eVVenta.ImpuestoVenta = eVenta.ImpuestoVenta;
            eVVenta.TotalVenta = eVenta.TotalVenta;
            eVVenta.EstadoVenta = eVenta.EstadoVenta;
            asNETVENTAS.Insertar_VVenta_I(eVVenta);
            EVDetalleVenta eVDetalleVenta = null;
            foreach (EDetalleVenta item in lstDetalleVenta)
            {
                eVDetalleVenta = new EVDetalleVenta();
                eVDetalleVenta.CodigoDetalleVenta = asNETVENTAS.Obtener_VDetalleVenta_O_SiguienteCodigoDetalleVenta();
                eVDetalleVenta.CodigoVenta = eVVenta.CodigoVenta;
                eVDetalleVenta.CodigoArticulo = item.CodigoArticulo;
                eVDetalleVenta.CantidadDetalleVenta = item.CantidadDetalleVenta;
                eVDetalleVenta.PrecioDetalleVenta = item.PrecioDetalleVenta;
                eVDetalleVenta.DescuentoDetalleVenta = item.DescuentoDetalleVenta;
                asNETVENTAS.Insertar_VDetalleVenta_I(eVDetalleVenta);
            }

        }
        catch (Exception)
        {
            throw;
        }

    }
    #endregion

    #region Tabla: VUsuario
    // Obtener último id
    public int Obtener_VUsuario_O_SiguienteCodigoUsuario()
    {
        try
        {
            return asNETVENTAS.Obtener_VUsuario_O_SiguienteCodigoUsuario();
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Insertar
    public void Insertar_VUsuario_I(int codigoUsuario, string nombresUsuario, string apellidosUsuario, string celularUsuario, string correoUsuario, string claveUsuario, string rolUsuario)
    {
        EVUsuario eVUsuario = new EVUsuario();
        try
        {
            eVUsuario.CodigoUsuario = codigoUsuario;
            eVUsuario.NombresUsuario = nombresUsuario;
            eVUsuario.ApellidosUsuario = apellidosUsuario;
            eVUsuario.CelularUsuario = celularUsuario;
            eVUsuario.CorreoUsuario = correoUsuario;
            eVUsuario.ClaveUsuario = claveUsuario;
            eVUsuario.RolUsuario = rolUsuario;
            asNETVENTAS.Insertar_VUsuario_I(eVUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener un registro
    public EVUsuario Obtener_VUsuario_O(int codigoUsuario)
    {
        try
        {
            return asNETVENTAS.Obtener_VUsuario_O(codigoUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Actualizar
    public void Actualizar_VUsuario_A(int codigoUsuario, string nombresUsuario, string apellidosUsuario, string celularUsuario, string correoUsuario, string claveUsuario, string rolUsuario, string estado)
    {
        EVUsuario eVUsuario = new EVUsuario();
        try
        {
            eVUsuario.CodigoUsuario = codigoUsuario;
            eVUsuario.NombresUsuario = nombresUsuario;
            eVUsuario.ApellidosUsuario = apellidosUsuario;
            eVUsuario.CelularUsuario = celularUsuario;
            eVUsuario.CorreoUsuario = correoUsuario;
            eVUsuario.ClaveUsuario = claveUsuario;
            eVUsuario.RolUsuario = rolUsuario;
            eVUsuario.Estado = estado;
            asNETVENTAS.Actualizar_VUsuario_A(eVUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    // Obtener todos los registros
    public List<EVUsuario> Obtener_VUsuario_O_Todo()
    {
        try
        {
            return asNETVENTAS.Obtener_VUsuario_O_Todo().ToList();
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
            asNETVENTAS.Eliminar_VUsuario_E(codigoUsuario);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}