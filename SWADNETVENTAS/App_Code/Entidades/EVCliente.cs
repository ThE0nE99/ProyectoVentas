using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EVCliente
/// </summary>
public class EVCliente
{
    #region Propiedades
    [DataMember]
    public int CodigoCliente { get; set; }
    [DataMember]
    public string RazonSocialCliente { get; set; }
    [DataMember]
    public string CiONitCliente { get; set; }
    [DataMember]
    public string TipoCliente { get; set; }
    [DataMember]
    public string DirecionCliente { get; set; }
    [DataMember]
    public string CelularCliente { get; set; }
    #region “Auditoría básica”
    [DataMember]
    public string Estado { get; set; }
    [DataMember]
    public DateTime FechaRegistro { get; set; }
    [DataMember]
    public DateTime FechaActualizacion { get; set; }
    #endregion
    #endregion

    #region Constructores
    public EVCliente()
    {
        CodigoCliente = int.MinValue;
        RazonSocialCliente = string.Empty;
        CiONitCliente = string.Empty;
        TipoCliente = string.Empty;
        DirecionCliente = string.Empty;
        CelularCliente = string.Empty;

        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaActualizacion = DateTime.MinValue;
    }
    #endregion
}