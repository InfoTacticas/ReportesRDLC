using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ReportePruebaTutorial01.Models
{
    public class DalConexion
    {
        

        public static String ObtenerCadenaConexion(){
            return @"Data Source=INROES\SQLSERVER2008R2; Initial Catalog=ReportesMVC_Logistica; uid=sa; pwd=sqlserver2008";            
        }

    }
}