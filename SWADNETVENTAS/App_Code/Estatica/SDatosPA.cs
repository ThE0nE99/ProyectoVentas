using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de SDatosPA
/// </summary>
public  static class SDatosPA
{
    #region Estados Auditoria Base de Datos
    public const string Auditoria_Activo = "AC";
    public const string Auditoria_Inactivo = "IN";
    #region Fechas Auditoria Base de Datos
    public static readonly DateTime Auditoria_FechaModificacion = DateTime.Now;
    public static readonly DateTime Auditoria_FechaRegistro = DateTime.Now;
    #endregion
    #endregion
}