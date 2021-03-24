using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Data.Interfaces.InterfaceServices
{
    public interface IServiceProduct
    {
        Task AddProduct(Produto produto);
        Task UpdateProduct(Produto produto);

        Task<List<Produto>> ListarProdutosComEstoque();
    }
}
