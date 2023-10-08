﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EVDetalleIngreso
/// </summary>
[DataContract]
public class EVDetalleIngreso
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
    public double PrecioIngreso { get; set; }
    #endregion

    #region Constructores
    public EVDetalleIngreso()
    {
        CodigoDetalleIngreso = int.MinValue;
        CodigoIngreso = int.MinValue;
        CodigoArticulo = int.MinValue;
        CantidadIngreso = int.MinValue;
        PrecioIngreso = double.MinValue;
    }
    #endregion
}