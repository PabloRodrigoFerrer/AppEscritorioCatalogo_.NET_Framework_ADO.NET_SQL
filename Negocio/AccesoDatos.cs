using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dominio;


namespace Negocio
{
    public class AccesoDatos
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector;}
        }

        public AccesoDatos()
        {
            try
            {
                conexion = new SqlConnection("server=.\\SQLEXPRESS; database= CATALOGO_DB; integrated security=True");
                comando = new SqlCommand();     

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public void setearConsulta(string consulta) 
        {           
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void setearParemetro(string clave, object valor) 
        {
            comando.Parameters.AddWithValue(clave, valor); 
        }

        public void ejecutarLector() 
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public void ejecutarAccion() 
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cerrarConexion() 
        {
            try
            {
                if (lector != null)
                    lector.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        

        

    }
}
