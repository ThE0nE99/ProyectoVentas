using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de EVUsuario
/// </summary>
[DataContract]
public class EVUsuario
{
    #region Propiedades
    [DataMember]
    public int CodigoUsuario { get; set; }
    [DataMember]
    public string NombresUsuario { get; set; }
    [DataMember]
    public string ApellidosUsuario { get; set; }
    [DataMember]
    public string CelularUsuario { get; set; }
    [DataMember]
    public string CorreoUsuario { get; set; }
    [DataMember]
    public string ClaveUsuario { get; set; }
    [DataMember]
    public string RolUsuario { get; set; }

    #region “Auditoría básica”
    [DataMember]
    public string Estado { get; set; }
    [DataMember]
    public DateTime FechaRegistro { get; set; }
    [DataMember]
    public DateTime FechaActulizacion { get; set; }
    #endregion
    #endregion

    #region Constructores
    public EVUsuario()
    {
        CodigoUsuario = int.MinValue;
        NombresUsuario = string.Empty;
        ApellidosUsuario = string.Empty;
        CelularUsuario = string.Empty;
        CorreoUsuario = string.Empty;
        ClaveUsuario = string.Empty;
        RolUsuario = string.Empty;

        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaActulizacion = DateTime.MinValue;
    }
    #endregion
}