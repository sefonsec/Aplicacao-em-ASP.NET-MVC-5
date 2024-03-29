﻿using Modelo.Cadastros;
using Persistencia.Contexts;
using System.Linq;

namespace Persistencia.DAL.Cadastros
{
    public class CategoriaDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<Categoria> ObterCategoriasClassificadasPorNome()
        {
            return context.Categorias.OrderBy(b => b.Nome);
        }
    }
}
