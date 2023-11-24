using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EVDetalleVenta
/// </summary>

[DataContract]
public class EVDetalleVenta
{
    #region Propiedades
    [DataMember]
    public int CodigoDetalleVenta { get; set; }
    [DataMember]
    public int CodigoVenta { get; set; }
    [DataMember]
    public int CodigoArticulo { get; set; }
    [DataMember]
    public int CantidadDetalleVenta { get; set; }
    [DataMember]
    public double PrecioDetalleVenta { get; set; }
    [DataMember]
    public double DescuentoDetalleVenta { get; set; }
    #endregion


    #region Constructores
    public EVDetalleVenta()
    {
        CodigoDetalleVenta = int.MinValue;
        CodigoVenta = int.MinValue;
        CodigoArticulo = int.MinValue;
        CantidadDetalleVenta = int.MinValue;
        PrecioDetalleVenta = double.MinValue;
        DescuentoDetalleVenta = double.MinValue;
    }
    #endregion
}