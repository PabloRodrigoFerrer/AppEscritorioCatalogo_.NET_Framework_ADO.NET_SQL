using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioMarca : IMarcaRepository
    {

        private readonly AccesoDatos _accesoDatos;

        public NegocioMarca(AccesoDatos accesoDatos) 
        {
            _accesoDatos = accesoDatos;
        }

        public IEnumerable<Marca> Listar() 
        {
            
            var listaMarcas = new List<Marca>();
            try
            {
                _accesoDatos.setearConsulta("SELECT Id, Descripcion FROM MARCAS");
                _accesoDatos.ejecutarLector();

                while (_accesoDatos.Lector.Read()) 
                {
                    Marca aux = new Marca();
                    aux.Id = (int)_accesoDatos.Lector["Id"];
                    aux.Descripcion = (string)_accesoDatos.Lector["Descripcion"];                              
                    
                    listaMarcas.Add(aux);
                }

                return listaMarcas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                _accesoDatos.cerrarConexion();
            }
        }
    }
}
