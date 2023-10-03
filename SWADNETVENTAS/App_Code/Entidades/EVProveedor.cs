using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EVProveedor
/// </summary>
[DataContract]
public class EVProveedor
{
    #region Propiedades
    [DataMember]
    public int CodigoProveedor { get; set; }
    [DataMember]
    public string TipoProveedor { get; set; }
    [DataMember]
    public string RazonSocialProveedor { get; set; }
    [DataMember]
    public string DireccionProveedor { get; set; }
    [DataMember]
    public string CelularProveedor { get; set; }
    [DataMember]
    public string CorreoProveedor { get; set; }
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
    public EVProveedor()
    {
        CodigoProveedor = int.MinValue;
        TipoProveedor = string.Empty;
        RazonSocialProveedor = string.Empty;
        DireccionProveedor = string.Empty;
        CelularProveedor = string.Empty;
        CorreoProveedor = string.Empty;

        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaActualizacion = DateTime.MinValue;
    }
    #endregion
}