using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using SWADNETVENTAS;

/// <summary>
/// Descripción breve de EVentaCompleta
/// </summary>
[DataContract]
public class EVenta
{
    #region Propiedades
    [DataMember]
    public int CodigoVenta { get; set; }
    [DataMember]
    public int CodigoCliente { get; set; }
    [DataMember]
    public int CodigoUsuario { get; set; }
    [DataMember]
    public DateTime FechaHoraVenta { get; set; }
    [DataMember]
    public double ImpuestoVenta { get; set; }
    [DataMember]
    public double TotalVenta { get; set; }
    [DataMember]
    public string EstadoVenta { get; set; }
    #endregion


    #region Constructores
    public EVenta()
    {
        CodigoVenta = int.MinValue;
        CodigoCliente = int.MinValue;
        CodigoUsuario = int.MinValue;
        FechaHoraVenta = DateTime.MinValue;
        ImpuestoVenta = double.MinValue;
        TotalVenta = double.MinValue;
        EstadoVenta = string.Empty;
    }
    #endregion
}