using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EDetalleIngreso
/// </summary>
public class EDetalleIngreso
{
    #region Propiedades
    [DataMember]
    public int CodigoDetalleIngreso { get; set; }
    [DataMember]
    public int CodigoIngreso { get; set; }
    [DataMember]
    public int CodigoArticulo { get; set; }
    [DataMember]
    public int CantidadIngreso { get; set; }
    [DataMember]
    public decimal PrecioIngreso { get; set; }
    #endregion

    #region Constructores
    public EDetalleIngreso()
    {
        CodigoDetalleIngreso = int.MinValue;
        CodigoIngreso = int.MinValue;
        CodigoArticulo = int.MinValue;
        CantidadIngreso = int.MinValue;
        PrecioIngreso = decimal.MinValue;
    }
    #endregion
}