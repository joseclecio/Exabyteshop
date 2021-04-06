using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationApp.Interfaces;
using Entities.Entities;
using Entities.Entities.Enums;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using LojaVirtual.Models;

namespace LojaVirtual.Controllers
{
    public class CompraUsuarioController : HelpQrCode
    {

        public readonly UserManager<Usuario> _userManager;
        public readonly InterfaceCompraUsuarioApp _InterfaceCompraUsuarioApp;
        private IWebHostEnvironment _environment;


        public CompraUsuarioController(UserManager<Usuario> userManager, InterfaceCompraUsuarioApp InterfaceCompraUsuarioApp, IWebHostEnvironment environment)
        {
            _userManager = userManager;
            _InterfaceCompraUsuarioApp = InterfaceCompraUsuarioApp;
            _environment = environment;
        }


        public async Task<IActionResult> FinalizarCompra()
        {
            var usuario = await _userManager.GetUserAsync(User);
            var compraUsuario = await _InterfaceCompraUsuarioApp.CarrinhoCompras(usuario.Id);
            return View(compraUsuario);
        }


        public async Task<IActionResult> MinhasCompras(bool mensagem = false)
        {
            var usuario = await _userManager.GetUserAsync(User);
            var compraUsuario = await _InterfaceCompraUsuarioApp.ProdutosComprados(usuario.Id);

            if (mensagem)
            {
                ViewBag.Sucesso = true;
                ViewBag.Mensagem = "Compra efetivada com sucesso. Pague o boleto para garantir sua compra!";
            }

            return View(compraUsuario);
        }


        public async Task<IActionResult> ConfirmaCompra()
        {
            var usuario = await _userManager.GetUserAsync(User);

            var sucesso = await _InterfaceCompraUsuarioApp.ConfirmaCompraCarrinhoUsuario(usuario.Id);

            if (sucesso)
            {
                return RedirectToAction("MinhasCompras", new { mensagem = true });
            }
            else
                return RedirectToAction("FinalizarCompra");
        }

        public async Task<IActionResult> Imprimir()
        {
            var usuario = await _userManager.GetUserAsync(User);

            var compraUsuario = await _InterfaceCompraUsuarioApp.ProdutosComprados(usuario.Id);

            return await Download(compraUsuario, _environment);

        }


        [HttpPost("/api/AdicionarProdutoCarrinho")]
        public async Task<JsonResult> AdicionarProdutoCarrinho(string id, string nome, string qtd)
        {
            var usuario = await _userManager.GetUserAsync(User);

            if (usuario != null)
            {
                await _InterfaceCompraUsuarioApp.Add(new CompraUsuario
                {
                    ProdutoId = Convert.ToInt32(id),
                    Quantidade = Convert.ToInt32(qtd),
                    EnumEstadoCompra = EnumEstadoCompra.Produto_Carrinho,
                    Id = usuario.Id
                });
                return Json(new { sucesso = true });
            }

            return Json(new { sucesso = false });

        }

        [HttpGet("/api/QtdProdutosCarrinho")]
        public async Task<JsonResult> QtdProdutosCarrinho()
        {
            var usuario = await _userManager.GetUserAsync(User);

            var qtd = 0;

            if (usuario != null)
            {
                qtd = await _InterfaceCompraUsuarioApp.QuantidadeProdutoCarrinhoUsuario(usuario.Id);

                return Json(new { sucesso = true, qtd = qtd });
            }

            return Json(new { sucesso = false, qtd = qtd });

        }

    }
}
