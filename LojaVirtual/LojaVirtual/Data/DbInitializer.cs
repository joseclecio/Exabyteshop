using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Models;
using LojaVirtual.Models.Enum;

namespace LojaVirtual.Data
    {
        public class DbInitializer
        {
            public static void Initialize(LojaContext context)
            {
                //context.Database.EnsureCreated();

                // Look for any Usuarios.
                if (context.Usuarios.Any())
                {
                    return;   // DB has been seeded
                }

                var usuarios = new Usuario[]
                {
                new Usuario{UsuarioID=01, Nome="Akeu", Tipo=TipoUsuario.Administrador},
                new Usuario{UsuarioID=02, Nome="JoseClecio", Tipo=TipoUsuario.Comum},
                new Usuario{UsuarioID=03, Nome="William", Tipo=TipoUsuario.Comum}
                };
                foreach (Usuario u in usuarios)
                {
                    context.Usuarios.Add(u);
                }
                context.SaveChanges();





                var produtos = new Produto[]
                {
                new Produto{ProdutoID=01, Nome="GTX 1660 Super", QuantidadeEstoque=200, UsuarioID=01},
                new Produto{ProdutoID=02, Nome="Ryzen 5 3600x", QuantidadeEstoque=200, UsuarioID=01},
                new Produto{ProdutoID=03, Nome="Steel Legend B450", QuantidadeEstoque=200, UsuarioID=01}
                };
                foreach (Produto p in produtos)
                {
                    context.Produtos.Add(p);
                }
                context.SaveChanges();




                var compraUsuarios = new CompraUsuario[]
                {
                new CompraUsuario{Quantidade=1, ProdutoID=1, UsuarioID=2}
                };

                foreach (CompraUsuario cp in compraUsuarios)
                {
                    context.CompraUsuarios.Add(cp);
                }
                context.SaveChanges();
            }
        }
}



