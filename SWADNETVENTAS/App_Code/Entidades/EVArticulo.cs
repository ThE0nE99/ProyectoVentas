using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EVArticulo
/// </summary>

[DataContract]
public class EVArticulo
{

    #region Propiedades
    [DataMember]
    public int CodigoArticulo { get; set; }
    [DataMember]
    public string CategoriaArticulo { get; set; }
    [DataMember]
    public string NombreArticulo { get; set; }
    [DataMember]
    public double PrecioCompraArticulo { get; set; }
    [DataMember]
    public double PrecioVentaArticulo { get; set; }
    [DataMember]
    public int StockArticulo { get; set; }
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
    public EVArticulo()
    {
        CodigoArticulo = int.MinValue;
        CategoriaArticulo = string.Empty;
        NombreArticulo = string.Empty;
        PrecioCompraArticulo = double.MinValue;
        PrecioVentaArticulo = double.MinValue;
        StockArticulo = int.MinValue;

        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaActualizacion = DateTime.MinValue;
    }
    #endregion
}