using LojaVirtual.Controllers;
using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Interfaces
{
    public interface InterfaceProductApp : InterfaceGenericaApp<Produto>
    {
        Task AddProduct(Produto produto);
        Task UpdateProduct(Produto produto);

        Task<List<Produto>> ListarProdutosUsuario(string userId);

        Task<List<Produto>> ListarProdutosComEstoque();
    }
}
