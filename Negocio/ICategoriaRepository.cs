﻿using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Listar(); 
    }
}
