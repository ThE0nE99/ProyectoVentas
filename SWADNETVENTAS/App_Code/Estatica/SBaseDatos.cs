using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de SBaseDatos
/// </summary>
public class SBaseDatos
{
    public static Database BDNETVENTAS = DatabaseFactory.CreateDatabase("VentasCadenaConexion");
}