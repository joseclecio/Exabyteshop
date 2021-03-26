using LojaVirtual.Configuration;
using LojaVirtual.Data;
using LojaVirtual.Data.Interfaces.InterfaceProduct;
using LojaVirtual.Models;
using LojaVirtual.Repository.Generics;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Repository.Repositories
{
    public class RepositoryProduct : RepositoryGenerics<Produto>, IProduct
    {

        private readonly DbContextOptions<ContextBase> _optionsbuilder;

        public RepositoryProduct()
        {
            _optionsbuilder = new DbContextOptions<ContextBase>();
        }

        public async Task<List<Produto>> ListarProdutos(Expression<Func<Produto, bool>> exProduto)
        {
            using (var banco = new ContextBase(_optionsbuilder))
            {
                return await banco.Produto.Where(exProduto).AsNoTracking().ToListAsync();
            }
        }

        public async Task<List<Produto>> ListarProdutosUsuario(string userId)
        {
            using (var banco = new ContextBase(_optionsbuilder))
            {
                return await banco.Produto.Where(p => p.Id == userId).AsNoTracking().ToListAsync();
            }
        }
    }
}
