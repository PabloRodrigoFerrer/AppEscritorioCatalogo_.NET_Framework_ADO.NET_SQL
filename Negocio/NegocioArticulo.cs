using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioArticulo
    {
        List<Articulo> listaArticulos;

        public List<Articulo> listar() 
        {
            listaArticulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, IdMarca, IdCategoria, ImagenUrl, Precio FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.id AND Precio != 0");
                datos.ejecutarLector();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];

                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["ImagenUrl"];

                    aux.Precio = (decimal)datos.Lector["Precio"];

                    listaArticulos.Add(aux);                    
                }

                return listaArticulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                datos.cerrarConexion();            
            }
        }
        
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) VALUES (@codigo, @nombre, @descripcion, @idmarca, @idcategoria, @urlimagen, @precio)");
                datos.setearParemetro("@codigo",nuevo.Codigo);
                datos.setearParemetro("@nombre", nuevo.Nombre);
                datos.setearParemetro("@descripcion", nuevo.Descripcion);
                datos.setearParemetro("@idmarca", nuevo.Marca.Id);
                datos.setearParemetro("@idcategoria", nuevo.Categoria.Id);
                datos.setearParemetro("@urlimagen", nuevo.UrlImagen);
                datos.setearParemetro("@precio", nuevo.Precio);

                datos.ejecutarAccion();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                datos.cerrarConexion();            
            }
        }    

        public void modificar(Articulo modificado) 
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idmarca, IdCategoria = @idcategoria, ImagenUrl = @urlimagen, Precio = @precio WHERE Id = @id");
                datos.setearParemetro("@codigo", modificado.Codigo);
                datos.setearParemetro("@nombre", modificado.Nombre);
                datos.setearParemetro("@descripcion", modificado.Descripcion);
                datos.setearParemetro("@idmarca", modificado.Marca.Id);
                datos.setearParemetro("@idcategoria", modificado.Categoria.Id);
                datos.setearParemetro("@urlimagen", modificado.UrlImagen);
                datos.setearParemetro("@precio", modificado.Precio);
                datos.setearParemetro("@id", modificado.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                datos.cerrarConexion();            
            }        
        }

        public void elminarFisico(int id) 
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE ID = @id");
                datos.setearParemetro("@id", id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }        
        }

        public void eliminarLogico(int id) 
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Precio = 0 WHERE Id = @id");
                datos.setearParemetro("@id", id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }       
        }

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Articulo> listaFiltro = new List<Articulo>();
            try
            {
                string consulta = "SELECT A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, IdMarca, IdCategoria, ImagenUrl, Precio FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.id AND Precio != 0 AND ";

                if (campo == "Marca")
                    campo = "M.Descripcion";
                else if (campo == "Categoria")
                    campo = "C.Descripcion";

                if (campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Mayor igual a":
                            consulta += $"{campo} >= @filtro";
                            break;
                        case "Menor igual a":
                            consulta += $"{campo} <= @filtro";
                            break;
                        case "Igual a":
                            consulta += $"{campo} = @filtro";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Empieza con":
                            consulta += $"{campo} LIKE @filtro";
                            filtro = filtro + "%";
                            break;
                        case "Termina con":
                            consulta += $"{campo} LIKE @filtro";
                            filtro = "%" + filtro;
                            break;
                        case "Contiene":
                            consulta += $"{campo} LIKE @filtro";
                            filtro = "%" + filtro + "%";
                            break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.setearParemetro("@filtro", filtro);
                datos.ejecutarLector();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    listaFiltro.Add(aux);
                }

                return listaFiltro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
            

    }
}
