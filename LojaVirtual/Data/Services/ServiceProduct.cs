using LojaVirtual.Data.Interfaces.InterfaceProduct;
using LojaVirtual.Data.Interfaces.InterfaceServices;
using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks; 

namespace LojaVirtual.Data.Services
{
    public class ServiceProduct : IServiceProduct
    {

        private readonly IProduct _IProduct;

        public ServiceProduct(IProduct IProduct)
        {
            _IProduct = IProduct;
        }

        public async Task AddProduct(Produto produto)
        {
            var validaNome = produto.ValidarPropriedadeString(produto.Nome, "Nome");

            var validaValor = produto.ValidarPropriedadeDecimal(produto.Valor, "Valor");

            var validaQtdEstoque = produto.ValidarPropriedadeInt(produto.QuantidadeEstoque, "QtdEstoque");

            if (validaNome && validaValor && validaQtdEstoque)
            {
                produto.DataCadastro = DateTime.Now;
                produto.DataAlteracao = DateTime.Now;
                produto.Estado = true;
                await _IProduct.Add(produto);
            }
        }

        public async Task<List<Produto>> ListarProdutosComEstoque()
        {
            return await _IProduct.ListarProdutos(p => p.QuantidadeEstoque > 0);
        }

        public async Task UpdateProduct(Produto produto)
        {
            var validaNome = produto.ValidarPropriedadeString(produto.Nome, "Nome");

            var validaValor = produto.ValidarPropriedadeDecimal(produto.Valor, "Valor");

            var validaQtdEstoque = produto.ValidarPropriedadeInt(produto.QuantidadeEstoque, "QtdEstoque");

            if (validaNome && validaValor && validaQtdEstoque)
            {
                produto.DataAlteracao = DateTime.Now;

                await _IProduct.Update(produto);
            }
        }
    }
}
