using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Negocio
{
    public class NegocioCategoria : ICategoriaRepository
    {
        private readonly AccesoDatos _accesoDatos;

        public NegocioCategoria(AccesoDatos datos) {

            _accesoDatos = datos;
        }

        public IEnumerable<Categoria> Listar() 
        {         
            var listaCategorias = new List<Categoria>();
            
            try
            {
                _accesoDatos.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                _accesoDatos.ejecutarLector();

                while (_accesoDatos.Lector.Read()) 
                {
                    listaCategorias.Add(new Categoria
                    {
                        Id = (int)_accesoDatos.Lector["Id"],
                        Descripcion = (string)_accesoDatos.Lector["Descripcion"]
                    });
                }
                
                return listaCategorias;
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






