using LojaVirtual.Data.Interfaces.Generics;
using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Data.Interfaces.InterfaceProduct
{
    public interface IProduct : IGeneric<Produto>
    {
        Task<List<Produto>> ListarProdutosUsuario(string userId);

        Task<List<Produto>> ListarProdutos(Expression<Func<Produto, bool>> exProduto);
    }
}
