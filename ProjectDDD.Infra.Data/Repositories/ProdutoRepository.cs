using ProjectDDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDDD.Domain.Entities;
using ProjectDDD.Domain.Interfaces.Repositories;

namespace ProjectDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(x => x.Nome.Contains(nome));
        }
    }
}
