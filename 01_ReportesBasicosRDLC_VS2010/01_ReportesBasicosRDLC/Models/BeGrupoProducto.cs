using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ReportePruebaTutorial01.Models
{
    public class BeGrupoProducto
    {
        public Int32 IdGrupoProducto { get; set; }
        public String Descripcion { get; set; }
        public Boolean Estado { get; set; }

        public static List<BeGrupoProducto> ObtenerListadoGrupo() {
            List<BeGrupoProducto> lstGrupoProducto = new List<BeGrupoProducto>();
            BeGrupoProducto obj = null;
            SqlConnection cnn = null;
            SqlDataReader reader=null;
            try
            {
                cnn = new SqlConnection(DalConexion.ObtenerCadenaConexion());
                cnn.Open();

                SqlCommand comando = new SqlCommand("SELECT IdGrupoProducto, Descripcion FROM GrupoProducto ORDER BY Descripcion", cnn);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    obj = new BeGrupoProducto();

                    obj.IdGrupoProducto = Convert.ToInt32(reader["IdGrupoProducto"]);
                    obj.Descripcion = Convert.ToString(reader["Descripcion"]);

                    lstGrupoProducto.Add(obj);
                }
            }
            catch(Exception ex){
            
            }
            finally{
                if (cnn != null)
                {
                    cnn.Close();
                    cnn.Dispose();                    
                }
                if (reader != null)
                    reader.Close();
            }

            return lstGrupoProducto;
        }
    }
}