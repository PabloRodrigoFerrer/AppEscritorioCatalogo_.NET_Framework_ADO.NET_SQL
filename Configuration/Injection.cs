using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration
{
    public static class Injection
    {
        public static AccesoDatos AccesoDatos => new AccesoDatos();
        public static ICategoriaRepository NegocioCategoria => new NegocioCategoria(Injection.AccesoDatos);

        public static IMarcaRepository NegocioMarca => new NegocioMarca(Injection.AccesoDatos);
    }
}
