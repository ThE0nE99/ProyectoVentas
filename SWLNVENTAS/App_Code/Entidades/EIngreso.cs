using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EIngreso
/// </summary>
public class EIngreso
{
    #region Propiedades
    [DataMember]
    public int CodigoIngreso { get; set; }
    [DataMember]
    public int CodigoProveedor { get; set; }
    [DataMember]
    public int CodigoUsuario { get; set; }
    [DataMember]
    public DateTime FechaIngreso { get; set; }
    [DataMember]
    public decimal ImpuestoIngreso { get; set; }
    [DataMember]
    public decimal TotalIngreso { get; set; }
    [DataMember]
    public string EstadoIngreso { get; set; }
    #endregion

    #region Constructores
    public EIngreso()
    {
        CodigoIngreso = int.MinValue;
        CodigoProveedor = int.MinValue;
        CodigoUsuario = int.MinValue;
        FechaIngreso = DateTime.MinValue;
        ImpuestoIngreso = decimal.MinValue;
        TotalIngreso = decimal.MinValue;
        EstadoIngreso = string.Empty;
    }
    #endregion
}